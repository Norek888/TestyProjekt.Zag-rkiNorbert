using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
namespace TestyProjekt.ZagórkiNorbert
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL:");
        }

        [Test]
        public void ExecuteTest()
        {
            
            //EnterText(element,value,type)
            SetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            SetMethods.EnterText(driver,"Initial","executeautomation","Name");

            Console.WriteLine("The value from my Title is:" + GetMethods.GetTextFromList(driver,"TitleId","Id"));
            
            Console.WriteLine("The value from my initial is:" + GetMethods.GetText(driver, "Initial", "Name"));
            SetMethods.Click(driver, "Save", "Name");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Close");
        }
    }
}
