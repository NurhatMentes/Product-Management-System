using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TechnicService.Core.Service
{
    public class UsdService
    {
        public decimal Usd()
        {
            string exchangeRate = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(exchangeRate);
            
            string usdType = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod ='USD']/BanknoteSelling").InnerXml.Replace(".",",");

            decimal usd =Convert.ToDecimal(usdType.Substring(0, 5));
            return Convert.ToDecimal(usd);
        }

    }
}
