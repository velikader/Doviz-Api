using DovizApi.Models;
using System.Xml;

namespace DovizApi.Repository
{
    public class Dovizler
    {

        public async Task<IEnumerable<DovizModel>> KurFiyatları()
        {
            var dovizler = new List<DovizModel>();

            var url = @"https://www.tcmb.gov.tr/kurlar/today.xml";

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(url);

            XmlNode root = xmlDoc.DocumentElement;

            XmlNodeList dovız_data = root.SelectNodes("//Currency");
            foreach (XmlNode item in dovız_data)
            {
                decimal.TryParse(item.ChildNodes[3].InnerText.Replace('.', ','), out decimal ForexAlis);
                decimal.TryParse(item.ChildNodes[4].InnerText.Replace('.', ','), out decimal ForexSatis);

                var doviz = new DovizModel()
                {
                    Isım = item.ChildNodes[1].InnerText.Trim(),
                    Kod = item.Attributes["Kod"].Value,
                    ForexAlis = ForexAlis,
                    ForexSatis = ForexSatis
                };

                dovizler.Add(doviz);
            }



            return dovizler;
        }
    }
}
