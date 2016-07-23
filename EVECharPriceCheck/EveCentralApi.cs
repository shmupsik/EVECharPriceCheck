using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;

namespace EVECharPriceCheck
{
    public static class EveCentralApi
    {
        const string url = "http://api.eve-central.com/api/marketstat/json";

        public const string typeid_PLEX = "29668";
        public const string typeid_SKILLEXT = "40519";
        public const string typeid_SKILLINJ = "40520";
        public const string systemid_JITA = "30000142";
        public const string systemid_AMARR = "30002187";
        public const string systemid_RENS = "30002510";
        public const string systemid_HEK = "30002053";

        #region EveCentralResponse
        [DataContract]
        private class MarketResponse
        {
            [DataMember(Name = "buy")]
            public MarketData buy { get; set; }
            [DataMember(Name = "all")]
            public MarketData all { get; set; }
            [DataMember(Name = "sell")]
            public MarketData sell { get; set; }
        }

        [DataContract]
        private class MarketData
        {
            [DataMember(Name = "forQuery")]
            public forQuery ForQuery { get; set; }
            [DataMember(Name = "volume")]
            public int volume { get; set; }
            [DataMember(Name = "wavg")]
            public decimal wavg { get; set; }
            [DataMember(Name = "avg")]
            public decimal avg { get; set; }
            [DataMember(Name = "variance")]
            public decimal variance { get; set; }
            [DataMember(Name = "stdDev")]
            public decimal stdDev { get; set; }
            [DataMember(Name = "median")]
            public decimal median { get; set; }
            [DataMember(Name = "fivePercent")]
            public decimal fivePercent { get; set; }
            [DataMember(Name = "max")]
            public decimal max { get; set; }
            [DataMember(Name = "min")]
            public decimal min { get; set; }
            [DataMember(Name = "highToLow")]
            public string highToLow { get; set; }
            [DataMember(Name = "generated")]
            public float generated { get; set; }
        }

        [DataContract]
        private class forQuery
        {
            [DataMember(Name = "bid")]
            public string bid { get; set; }
            [DataMember(Name = "types")]
            public string[] types { get; set; }
            [DataMember(Name = "regions")]
            public string[] regions { get; set; }
            [DataMember(Name = "systems")]
            public string[] systems { get; set; }
            [DataMember(Name = "hours")]
            public string hours { get; set; }
            [DataMember(Name = "minq")]
            public string minq { get; set; }
        }
        #endregion

        public static ItemPrice GetPrice(string typeid, string[] regionid, string[] systemid)
        {
            ItemPrice result = new ItemPrice();

            // Создаём объект WebClient
            using (var webClient = new WebClient())
            {
                webClient.QueryString.Add("typeid", typeid);
                if (regionid.Count() > 0)
                {
                    webClient.QueryString.Add("useregion", String.Join(",", regionid));
                }
                if (systemid.Count() > 0)
                {
                    webClient.QueryString.Add("usesystem", String.Join(",", systemid));
                }

                try
                {
                    var responseStream = webClient.OpenRead(url);

                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(MarketResponse[]));
                    MarketResponse[] marketResponse = (MarketResponse[])serializer.ReadObject(responseStream);

                    responseStream.Close();

                    foreach ( MarketResponse T in marketResponse ) {
                        result.TypeId = typeid;
                        result.MinBuy = T.buy.min;
                        result.MaxBuy = T.buy.max;
                        result.MinSell = T.sell.min;
                        result.MaxSell = T.sell.max;
                    }

                }
                catch (WebException e)
                {
                    MessageBox.Show(e.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }

            }

            return result;

        }

        public static List<ItemPrice> GetPrices(string[] typeid, string[] regionid, string[] systemid)
        {
            List<ItemPrice> result = new List<ItemPrice>();

            // Создаём объект WebClient
            using (var webClient = new WebClient())
            {
                webClient.QueryString.Add("typeid", String.Join(",", typeid));
                if (regionid.Count() > 0)
                {
                    webClient.QueryString.Add("useregion", String.Join(",", regionid));
                }
                if (systemid.Count() > 0)
                {
                    webClient.QueryString.Add("usesystem", String.Join(",", systemid));
                }

                try
                {
                    var responseStream = webClient.OpenRead(url);

                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(MarketResponse[]));
                    MarketResponse[] marketResponse = (MarketResponse[])serializer.ReadObject(responseStream);

                    responseStream.Close();

                    foreach (MarketResponse T in marketResponse)
                    {
                        ItemPrice item = new ItemPrice();
                        item.TypeId = T.all.ForQuery.types[0];
                        item.MinBuy = T.buy.min;
                        item.MaxBuy = T.buy.max;
                        item.MinSell = T.sell.min;
                        item.MaxSell = T.sell.max;
                        result.Add(item);
                    }

                }
                catch (WebException e)
                {
                    MessageBox.Show(e.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }

            }

            return result;

        }
    }
}
