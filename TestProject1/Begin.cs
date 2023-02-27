
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject1
{
    public class Begin
    {
        public IWebDriver driver;
        public bool driverQuit = true;


        [SetUp]
        public void InicioTeste()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.buscacep.correios.com.br");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driverQuit = false;
        }

      

        [TearDown]
        public void FimDoTeste()
        { 
           if (driverQuit) driver.Quit();
        }
    }
}