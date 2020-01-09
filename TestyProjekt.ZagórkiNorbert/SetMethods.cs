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
        public static void EnterText( string element, string value, PropertyType elementtype)
        {
            switch (elementtype)
            {
                case PropertyType.Id:
                    PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
                    break;
                case PropertyType.Name:
                    PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
                    break;
            }
        }

        //Click into a button Checkbox, option
        public static void Click( string element, PropertyType elementtype)
        {
            switch (elementtype)
            {
                case PropertyType.Id:
                    PropertiesCollection.driver.FindElement(By.Id(element)).Click();
                    break;
                case PropertyType.Name:
                    PropertiesCollection.driver.FindElement(By.Name(element)).Click();
                    break;
            }
        }

        //Selecting a drop down control
        public static void SelectDropDown( string element, string value, PropertyType elementtype)
        {
            switch (elementtype)
            {
                case PropertyType.Id:
                    new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
                    break;
                case PropertyType.Name:
                    new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
                    break;
            }
        }
    }
}
