using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestyProjekt.ZagórkiNorbert
{
    class SetMethods
    {
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            switch (elementtype)
            {
                case "Id":
                    driver.FindElement(By.Id(element)).SendKeys(value);
                    break;
                case "Name":
                    driver.FindElement(By.Name(element)).SendKeys(value);
                    break;
            }
        }

        //Click into a button Checkbox, option
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            switch (elementtype)
            {
                case "Id":
                    driver.FindElement(By.Id(element)).Click();
                    break;
                case "Name":
                    driver.FindElement(By.Name(element)).Click();
                    break;
            }
        }

        //Selecting a drop down control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            switch (elementtype)
            {
                case "Id":
                    new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
                    break;
                case "Name":
                    new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
                    break;
            }
        }
    }
}
