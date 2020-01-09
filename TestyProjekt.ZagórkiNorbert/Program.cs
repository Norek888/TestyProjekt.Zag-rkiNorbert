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

            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL:");
        }

        [Test]
        public void ExecuteTest()
        {

            //Logowanie do aplikacji

            LoginPage pageLogin = new LoginPage();
            EAPageObject pageEA = pageLogin.Login("krzysiu", "1234");

            pageEA.FillUserForm("KK","Zagorski", "Norbert");

        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close");
        }
    }
}
