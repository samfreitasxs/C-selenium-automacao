using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace TestProject1
{
    internal class BuscaCep : Begin
    {
        [Test]
        public void Teste()
        {
            driver.FindElement(By.Id("endereco")).SendKeys("87035604");
            driver.FindElement(By.Id("btn_pesquisar")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id=\'resultado-DNEC\']/tbody/tr/td[1]")).Text.Contains("Rua Pioneiro Hélio dos Reis Figueiredo"), Is.True);
            

        }
    }
}
