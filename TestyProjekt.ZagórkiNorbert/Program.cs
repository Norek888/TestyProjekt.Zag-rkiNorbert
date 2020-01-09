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
        
        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL:");
        }

        [Test]
        public void ExecuteTest()
        {
            
            //EnterText(element,value,type)
            SetMethods.SelectDropDown( "TitleId", "Mr.", PropertyType.Id);

            SetMethods.EnterText("Initial","executeautomation",PropertyType.Name);

            Console.WriteLine("The value from my Title is:" + GetMethods.GetTextFromList("TitleId",PropertyType.Id));
            
            Console.WriteLine("The value from my initial is:" + GetMethods.GetText( "Initial", PropertyType.Name));
            SetMethods.Click( "Save", PropertyType.Name);
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close");
        }
    }
}
