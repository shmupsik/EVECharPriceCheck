using System;
using System.Xml.Serialization;

namespace EVECharPriceCheck
{
    public static class EveConstant
    {
        public static int MinSkillPointsAfterExtraction = 5000000;
        public static int SkillExtractorExtractPoints = 500000;
        public static int SkillInjectorDefaultInjectPoints = 500000;
        public static int NewCharSkillPoints = 399718;
        public static int AverageSkillPointPerHour = 1900;
        public static decimal NewCharInjectedSkillBooksCost = 11239500;
    }

    public class SkillDataResponse
    {
        public int TotalSkillPoints { get; set; }
        public int UnallocatedSkillPoints { get; set; }
        public string[] SkillsList { get; set; }
        public bool ApiKeyExpired { get; set; }
        public bool IsRestricted { get; set; }
        public bool IsSuccessful { get; set; }

        public SkillDataResponse()
        {
            TotalSkillPoints = 0;
            UnallocatedSkillPoints = 0;
            SkillsList = new string[] { };
            ApiKeyExpired = false;
            IsRestricted = false;
            IsSuccessful = false;

        }

        public bool IsEmpty()
        {
            return !((TotalSkillPoints > 0) && (SkillsList.Length > 0));
        }
    }



    [Serializable]
    public class EveCustomItem
    {
        [XmlElement("name")]
        public string name { get; set; }
        [XmlElement("typeid")]
        public string TypeId { get; set; }

        public EveCustomItem()
        {
            name = "";
            TypeId = "";
        }

        public EveCustomItem(string name, string typeid)
        {
            this.name = name;
            this.TypeId = typeid;
        }
    }

    [Serializable, XmlType("skill"), XmlRoot("skills")]
    public class EveMarketItem : EveCustomItem
    {
        [XmlElement("sellbynpc")]
        public bool sellbynpc { get; set; }
        [XmlElement("cost")]
        public decimal MinSell { get; set; }
        [XmlIgnore]
        public decimal MaxSell { get; set; }
        [XmlIgnore]
        public decimal MinBuy { get; set; }
        [XmlIgnore]
        public decimal MaxBuy { get; set; }

        public EveMarketItem() : base()
        {
            sellbynpc = true;
            MinSell = 0;
            MaxSell = 0;
            MinBuy = 0;
            MaxBuy = 0;
        }

        public EveMarketItem(string name, string typeid, decimal cost, bool sellbynpc) : base(name, typeid)
        {
            this.MinSell = cost;
            this.sellbynpc = sellbynpc;
        }


    }

 

}

