using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace LeS.AzureStatus.App
{
    class Program
    {
        static void Main(string[] args)
        {
            PesquisarIphoneGoogle();
        }

        static void PesquisarIphoneGoogle()
        {
            const string url = "https://www.google.com/";
            const string texto = "Iphone";

            using var driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Navigate().GoToUrl(url);

            var campoPesquisar = driver.FindElement(By.Name("q"));
            campoPesquisar.SendKeys(texto);

            var btnPesquisar = driver.FindElement(By.Name("btnK"));
            btnPesquisar.Click();
        }
    }
}
