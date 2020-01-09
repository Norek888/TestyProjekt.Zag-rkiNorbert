using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestyProjekt.ZagórkiNorbert
{
    class GetMethods
    {
        public static string GetText( string element, PropertyType elementtype)
        {
            switch (elementtype)
            {
                case PropertyType.Id:
                    return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
                case PropertyType.Name:
                    return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
                default:
                    return  String.Empty;
            }
        }
        public static string GetTextFromList( string element, PropertyType elementtype)
        {
            switch (elementtype)
            {
                case PropertyType.Id:
                    return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
                case PropertyType.Name:
                    return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
                default:
                    return String.Empty;
            }
        }
        
    }
}
