using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Sara
{
    public class TestLogin {
        IWebDriver driver;
        LoginPage loginPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://saralabs.grupokonecta.co:8591/externa_frontend/login");
            loginPage = new LoginPage(driver);
        }


        [Test]
        public void TestSuccessfulLogin()
        {
            loginPage.Login("Sergio.anaya", "Sistemas_890337*");
            

            // Realiza afirmaciones según el comportamiento después del inicio de sesión exitoso
          //  Assert.Equals(driver.Title.Contains("Página principal")); // Por ejemplo, verifica el título de la página después del inicio de sesión
        }

        [Test]
        public void TestFailedLogin()
        {
            loginPage.Login("usuario_invalido", "contrasena_invalida");

            // Realiza afirmaciones según el comportamiento después del inicio de sesión fallido
           // Assert.IsTrue(driver.PageSource.Contains("Credenciales incorrectas")); // Por ejemplo, verifica un mensaje de error en la página
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

    }
}
