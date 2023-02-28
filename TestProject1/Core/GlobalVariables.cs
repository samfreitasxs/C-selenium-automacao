using OpenQA.Selenium;


namespace TestProject1.Core
{
    public class GlobalVariables
    {
        // Define 'driver' como trigger para os WebeElements
        public IWebDriver driver;
        
        // Define 'fechar navegador ao final do teste' como padrao
        public bool driverQuit = true;
    }
}
