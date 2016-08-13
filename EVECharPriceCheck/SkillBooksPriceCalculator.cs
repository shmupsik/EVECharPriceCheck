using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EVECharPriceCheck
{

    public static class SkillBooksPriceCalculator
    {
        private const string SkillsPath = @"Resources\eve-skills.xml";

        private static bool booksDataLoaded;
        public static bool BooksDataLoaded
        {
            get
            {
                return booksDataLoaded;
            }
        }


        private static EveMarketItem[] skillBooksList;
        public static EveMarketItem[] SkillBooksList
        {
            get
            {
                return skillBooksList;
            }
        }

        static SkillBooksPriceCalculator()
        {
            booksDataLoaded = false;

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), SkillsPath);

            //skillBooksList = new EveMarketItem[] { new EveMarketItem("Name", "Type", 1, true), new EveMarketItem("Name2", "Type2", 1, true) };
            //XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(EveMarketItem[]), new XmlRootAttribute("skills"));
            //StringWriter stringWriter = new StringWriter();
            //xmlSerializer1.Serialize(stringWriter, skillBooksList);
            //File.WriteAllText(path, stringWriter.ToString());

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var xmlSerializer = new XmlSerializer(typeof(EveMarketItem[]), new XmlRootAttribute("skills"));
                    skillBooksList = (EveMarketItem[])xmlSerializer.Deserialize(sr);
                }
                booksDataLoaded = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static decimal GetSkillBooksPrice(string[] InjectedSkills, string[] regionid, string[] systemid)
        {
            decimal result = 0;

            var notFoundedItems = new List<EveMarketItem>();

            foreach (string InjectedSkill in InjectedSkills)
            {

                var item = Array.Find(skillBooksList, p => p.name.Equals(InjectedSkill, StringComparison.InvariantCultureIgnoreCase));
                if (item != null)
                {
                    if ((item.MinSell == 0) || (!item.sellbynpc))
                    {
                        notFoundedItems.Add(item);
                    }
                    else
                    {
                        result += item.MinSell;
                    }
                }

            }

            if (notFoundedItems.Count > 0)
            {
                var itemsid = notFoundedItems.Select(p => p.TypeId).ToArray();
                var ItemPricesList = EveCentralApi.GetPrices(itemsid, regionid, systemid);
                foreach (var item in ItemPricesList)
                {
                    result += item.MinSell;
                }
            }

            return result;
        }

    }



}
