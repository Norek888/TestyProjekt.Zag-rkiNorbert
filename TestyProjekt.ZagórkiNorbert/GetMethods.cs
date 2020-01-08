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
        public static string GetText(IWebDriver driver, string element, string elementtype)
        {
            switch (elementtype)
            {
                case "Id":
                    return driver.FindElement(By.Id(element)).GetAttribute("value");
                case "Name":
                    return driver.FindElement(By.Name(element)).GetAttribute("value");
                default:
                    return  String.Empty;
            }
        }
        public static string GetTextFromList(IWebDriver driver, string element, string elementtype)
        {
            switch (elementtype)
            {
                case "Id":
                    return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
                case "Name":
                    return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
                default:
                    return String.Empty;
            }
        }
        
    }
}
