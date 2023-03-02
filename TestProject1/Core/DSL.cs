using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TestProject1.Core
{
    public class DSL : GlobalVariables
    {
        #region Funcoes de manipulacao

        public static void Espere(int time) => Thread.Sleep(time);

        public void LimparCampo(string element) => driver.FindElement(By.XPath(element)).Clear();

        public void ClicaFora() => driver.FindElement(By.XPath("//html")).Click();


        public void EsperaElemento(string element, int seconds = 90)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until((d) => { return d.FindElement(By.XPath(element)); });
        }

        public void EsperaElementoSumir(string element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            wait.Until(d => d.FindElements(By.XPath(element)).Count == 0);
        }

        public bool ValidaElementoExistente(string xPath)
        {
            try
            { driver.FindElement(By.XPath(xPath)); return true; }
            catch (NoSuchElementException) { return false; }
        }
        #endregion

        #region Funcoes de Interacao
        public void EscreveTexto(string xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        public void ClicaElemento(string element)
        {
            driver.FindElement(By.XPath(element)).Click();
        }

        public void ValidaDados(string xpath, string value)
        {
            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));
        }
        #endregion

        #region Funcoes de Atribuicao

        public static string GeraNomeAleatorio()
        {
            var rnd = new Random();
            string[] nome = { "Samuel", "Maria", "Ricardo", "Ana", "Catarina" };
            string[] sobrenome = { "Freitas", "Silva", "Santos", "Mota", "Linhares" };
            string nomeCompleto = nome[rnd.Next(nome.Length)] + " " + sobrenome[rnd.Next(nome.Length)];
            Console.WriteLine();
            return nomeCompleto;
        }

        public static string GeraEmailAleatorio()
        {
            var rnd = new Random();
            string[] nome = { "Samuel", "Maria", "Ricardo", "Ana", "Catarina" };
            string[] sobrenome = { "Freitas", "Silva", "Santos", "Mota", "Linhares" };
            string[] dominio = { "teste@icloud.com", "algumacoisa_u@gmail.com", "xpto_09@gmail.com.br", "alex_silva@teste.com", "qa_qateste@neon.com" };
            string email = nome[rnd.Next(nome.Length)] + "." + sobrenome[rnd.Next(sobrenome.Length)] + dominio[rnd.Next(dominio.Length)];
            return email.ToLower();
        }

        public static string GeraDataNascimento()
        {
            var rnd = new Random();
            int dia = rnd.Next(1, 28);
            int mes = rnd.Next(1, 12);
            int ano = rnd.Next(1950, 2000);
            string dataNasc = dia.ToString().PadLeft(2, '0') + mes.ToString().PadLeft(2, '0') + ano;
            return dataNasc;
        }

        public static string GeraCelularAleatorio()
        {
            var rnd = new Random();
            string celNumber = string.Empty;
            for (int i = 0; i < 11; i++)
                celNumber = string.Concat(celNumber, rnd.Next(10));
            return celNumber;
        }

        #endregion
    }
}
