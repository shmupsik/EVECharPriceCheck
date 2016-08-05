using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EVECharPriceCheck
{
    class EveCharPriceCalculator
    {
        private bool isUpdating;

        #region Read-write fields

        private int skillPoints;
        private int delayHours;
        private decimal skillExtractorMinSellPrice;
        private decimal skillInjectorMaxBuyPrice;
        private decimal skillInjectorMinSellPrice;
        private decimal plexMinSellPrice;
        private decimal injectedSkillsPrice;


        public decimal SkillExtractorMinSellPrice
        {
            get
            {
                return skillExtractorMinSellPrice;
            }

            set
            {
                skillExtractorMinSellPrice = value;
                if (!isUpdating)
                {
                    Calculate();
                }
            }
        }

        public decimal SkillInjectorMaxBuyPrice
        {
            get
            {
                return skillInjectorMaxBuyPrice;
            }

            set
            {
                skillInjectorMaxBuyPrice = value;
                if (!isUpdating)
                {
                    Calculate();
                }
            }
        }

        public decimal SkillInjectorMinSellPrice
        {
            get
            {
                return skillInjectorMinSellPrice;
            }

            set
            {
                skillInjectorMinSellPrice = value;
                if (!isUpdating)
                {
                    Calculate();
                }
            }
        }

        public decimal PlexMinSellPrice
        {
            get
            {
                return plexMinSellPrice;
            }

            set
            {
                plexMinSellPrice = value;
                if (!isUpdating)
                {
                    Calculate();
                }
            }
        }

        public int SkillPoints
        {
            get
            {
                return skillPoints;
            }

            set
            {
                skillPoints = value;
                if (!isUpdating)
                {
                    Calculate();
                }
            }
        }

        public int DelayHours
        {
            get
            {
                return delayHours;
            }

            set
            {
                delayHours = value;
                if (!isUpdating)
                {
                    Calculate();
                }
            }
        }

        public decimal InjectedSkillsPrice
        {
            get
            {
                return injectedSkillsPrice;
            }

            set
            {
                injectedSkillsPrice = value;
                if (!isUpdating)
                {
                    Calculate();
                }
            }
        }

        #endregion

        #region Read-only fields

        private decimal resultIskMinPrice;
        private decimal resultIskMaxPrice;
        private decimal resultIskToTrainToMinExtractPoints;
        private decimal resultPlexMinPrice;
        private decimal resultPlexMaxPrice;
        private int resultSkillExtractorsItemsRequired;
        private int resultSkillInjectorsItemsRequired;
        private int resultSkillInjectorsExtraItemsRequired;

        public decimal ResultIskMinPrice
        {
            get
            {
                return resultIskMinPrice;
            }
        }

        public decimal ResultIskMaxPrice
        {
            get
            {
                return resultIskMaxPrice;
            }
        }

        public decimal ResultIskToTrainToMinExtractPoints
        {
            get
            {
                return resultIskToTrainToMinExtractPoints;
            }
        }

        public decimal ResultPlexMinPrice
        {
            get
            {
                return resultPlexMinPrice;
            }
        }

        public decimal ResultPlexMaxPrice
        {
            get
            {
                return resultPlexMaxPrice;
            }
        }

        public int ResultSkillExtractorsItemsRequired
        {
            get
            {
                return resultSkillExtractorsItemsRequired;
            }
        }

        public int ResultSkillInjectorsItemsRequired
        {
            get
            {
                return resultSkillInjectorsItemsRequired;
            }
       }

        public int ResultSkillInjectorsExtraItemsRequired
        {
            get
            {
                return resultSkillInjectorsExtraItemsRequired;
            }
        }

        #endregion

        public event EventHandler CalculationCompleted;
        protected virtual void OnCalculationCompleted(EventArgs e)
        {
            CalculationCompleted?.Invoke(this, e);
        }

        public EveCharPriceCalculator()
        {
            resultIskMinPrice = 0;
            resultIskMaxPrice = 0;
            resultPlexMinPrice = 0;
            resultPlexMaxPrice = 0;
            resultSkillExtractorsItemsRequired = 0;
            resultSkillInjectorsItemsRequired = 0;
            injectedSkillsPrice = 0;

            skillPoints = 0;
            delayHours = 24;
            skillExtractorMinSellPrice = 0;
            skillInjectorMaxBuyPrice = 0;
            skillInjectorMinSellPrice = 0;
            plexMinSellPrice = 0;

            isUpdating = false;
        }


        public void BeginUpdate()
        {
            isUpdating = true;
        }

        public void EndUpdate()
        {
            isUpdating = false;
        }


        public void Calculate()
        {

            //Calculating Minimum ISK price
            resultSkillExtractorsItemsRequired = (skillPoints - EveConstant.MinSkillPointsAfterExtraction) / EveConstant.SkillExtractorExtractPoints; //All types integer! Otherwise we should use floor() here for correct answer.
            if (resultSkillExtractorsItemsRequired < 0)
            {
                resultSkillExtractorsItemsRequired = 0;
            }
            resultIskMinPrice = skillInjectorMaxBuyPrice * resultSkillExtractorsItemsRequired - skillExtractorMinSellPrice * resultSkillExtractorsItemsRequired; //ehh, I know that x * y - z * y = y * (x - z)


            //count extra Skill Injectors which one should use to create character with remaining after extraction points.
            //Generally it will be ((EveConstant.MinSkillPointsAfterExtraction - EveConstant.NewCharSkillPoints) / EveConstant.SkillExtractorDefaultInjectPoints), but lets count more accurate
            resultSkillInjectorsExtraItemsRequired = 0;

            int remainingSkillPoints = skillPoints - (resultSkillExtractorsItemsRequired * EveConstant.SkillExtractorExtractPoints);

            float TimeToNextLevel = (remainingSkillPoints - EveConstant.NewCharSkillPoints) / EveConstant.AverageSkillPointPerHour;
            int skillPointsCounter = EveConstant.NewCharSkillPoints;
            while (skillPointsCounter < remainingSkillPoints)
            {
                TimeToNextLevel = (skillPoints - skillPointsCounter) / EveConstant.AverageSkillPointPerHour;

                skillPointsCounter += GetSkillPointsCount(skillPointsCounter); //increase skillpoints according to CCP table (injected SP depending on current character SP)

                resultSkillInjectorsExtraItemsRequired++;
            }

            if (TimeToNextLevel < delayHours) //we don't need to buy extra injector if time to train character to adjusted skill points is less than DelayHours
            {
                resultSkillInjectorsExtraItemsRequired--;
            }
            if (resultSkillInjectorsExtraItemsRequired < 0)
            {
                resultSkillInjectorsExtraItemsRequired = 0;
            }

            resultIskToTrainToMinExtractPoints = resultSkillInjectorsExtraItemsRequired * skillInjectorMinSellPrice;
            //Calculating Minimum ISK price



            //Calculating Maximum ISK price
            resultSkillInjectorsItemsRequired = 0;

            TimeToNextLevel = (skillPoints - EveConstant.NewCharSkillPoints) / EveConstant.AverageSkillPointPerHour;
            skillPointsCounter = EveConstant.NewCharSkillPoints;
            while (skillPointsCounter < skillPoints)
            {
                TimeToNextLevel = (skillPoints - skillPointsCounter) / EveConstant.AverageSkillPointPerHour;

                skillPointsCounter += GetSkillPointsCount(skillPointsCounter); //increase skillpoints according to CCP table (injected SP depending on current character SP)

                resultSkillInjectorsItemsRequired++;
            }

            if (TimeToNextLevel < delayHours) //we don't need to buy extra injector if time to train character to adjusted skill points is less than DelayHours
            {
                resultSkillInjectorsItemsRequired--;
            }
            if (resultSkillInjectorsItemsRequired < 0)
            {
                resultSkillInjectorsItemsRequired = 0;
            }
            resultIskMaxPrice = resultSkillInjectorsItemsRequired * skillInjectorMinSellPrice + injectedSkillsPrice;
            //Calculating Maximum ISK price


            //Calculating Minimum PLEX price
            if (plexMinSellPrice > 0)
            {
                resultPlexMinPrice = Math.Round(ResultIskMinPrice / plexMinSellPrice * 2) / 2; //round plex price to 0.5
            }
            //Calculating Minimum PLEX price


            //Calculating Maximum PLEX price
            if (plexMinSellPrice > 0)
            {
                resultPlexMaxPrice = Math.Round(ResultIskMaxPrice / plexMinSellPrice * 2) / 2; //round plex price to 0.5
            }
            //Calculating Maximum PLEX price


            //rase the event
            OnCalculationCompleted(EventArgs.Empty);
        }

        private int GetSkillPointsCount(int CurrentSkillPoints)
        {
            int result = EveConstant.SkillExtractorDefaultInjectPoints;

            if (CurrentSkillPoints >= 100000000)
            {
                result = 150000;
            }
            else if (CurrentSkillPoints >= 80000000)
            {
                result = 300000;
            }
            else if (CurrentSkillPoints >= 50000000)
            {
                result = 400000;
            }

            return result;
        }


        public static string FormatValue(decimal value, int decimals = 1)
        {
            StringBuilder suffix = new StringBuilder();

            while (value >= 1000)
            {
                value /= 1000;
                suffix.Append("k");
            }
            
            return String.Format(String.Concat("{0:F", decimals, "} {1}"), value, suffix.ToString()).Trim();
        }
    }

}
