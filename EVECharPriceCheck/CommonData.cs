using System;
using System.Xml.Serialization;

namespace EVECharPriceCheck
{
    public static class EveConstant
    {
        public static int MinSkillPointsAfterExtraction = 5000000;
        public static int SkillExtractorExtractPoints = 500000;
        public static int SkillExtractorDefaultInjectPoints = 500000;
        public static int NewCharSkillPoints = 399718;
        public static int AverageSkillPointPerHour = 1900;
        public static decimal NewCharInjectedSkillBooksCost = 11239500;
    }

    public class ItemPrice
    {
        public string TypeId { get; set; }
        public decimal MinBuy { get; set; }
        public decimal MaxBuy { get; set; }
        public decimal MinSell { get; set; }
        public decimal MaxSell { get; set; }

        public ItemPrice()
        {
            TypeId = "";
            MinBuy = 0;
            MaxBuy = 0;
            MinSell = 0;
            MaxSell = 0;
        }

    }

    public class SkillDataResponse
    {
        public int TotalSkillPoints { get; set; }
        public string[] SkillsList { get; set; }
        public bool ApiKeyExpired { get; set; }
        public bool IsRestricted { get; set; }

        public SkillDataResponse()
        {
            TotalSkillPoints = 0;
            SkillsList = new string[] { };
            ApiKeyExpired = false;
            IsRestricted = false;
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
        public string typeid { get; set; }

        public EveCustomItem()
        {
            name = "";
            typeid = "";
        }

        public EveCustomItem(string name, string typeid)
        {
            this.name = name;
            this.typeid = typeid;
        }
    }

    [Serializable, XmlType("skill"), XmlRoot("skills")]
    public class EveMarketItem : EveCustomItem
    {
        [XmlElement("cost")]
        public decimal cost { get; set; }
        [XmlElement("sellbynpc")]
        public bool sellbynpc { get; set; }

        public EveMarketItem() : base()
        {
            cost = 0;
            sellbynpc = true;
        }

        public EveMarketItem(string name, string typeid, decimal cost, bool sellbynpc) : base(name, typeid)
        {
            this.cost = cost;
            this.sellbynpc = sellbynpc;
        }


    }

 

}

