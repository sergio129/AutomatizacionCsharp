using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sara
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement CampoUsuario => driver.FindElement(By.Id("loginUserName"));
        public IWebElement CampoContras => driver.FindElement(By.Id("loginPassword"));
        public IWebElement CampoEstrellas => driver.FindElement(By.XPath("//p[@class='clasification']//label[@for='idRadioSurvey5']"));
        public IWebElement BotonLogin => driver.FindElement(By.Id("loginIngresar"));

        public void Login(string username, string password)
        {
            CampoUsuario.SendKeys(username);
            CampoContras.SendKeys(password);
            CampoEstrellas.Click();
            BotonLogin.Click();
            Thread.Sleep(5000);
        }
    }
}
