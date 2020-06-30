using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace NUnitTestProject1
{
    public class Tests
    {

        private IWebDriver driver;
        private Actions builder;

        

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            builder = new Actions(driver);
            

           

        }

        [Test]
        public void negativeTestRegistrationEmail()
        {
            var signInButton = driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a"));
            signInButton.Click();

            Thread.Sleep(2000);

            var emailCreateAccount = driver.FindElement(By.Id("email_create"));
            emailCreateAccount.SendKeys("email12345");

            Thread.Sleep(2000);

            var emailCreateButtonClick = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button/span"));
            emailCreateButtonClick.Click();


        }

        [Test]

        public void negativeTestRegistrationFirstName()
        {

            // this code will make six invalid registration form fields

            var signInButton = driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a"));
            signInButton.Click();

            Thread.Sleep(2000);

            var emailCreateAccount = driver.FindElement(By.Id("email_create"));
            emailCreateAccount.SendKeys("reno15d@abv.bg");

            Thread.Sleep(2000);

            var emailCreateButtonClick = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button/span"));
            emailCreateButtonClick.Click();

            Thread.Sleep(2000);

            var firstNameRegistarion = driver.FindElement(By.Id("customer_firstname"));
            firstNameRegistarion.SendKeys("12345678910");
            

            Thread.Sleep(1000);

            var lastNameRegistration = driver.FindElement(By.Id("customer_lastname"));
            lastNameRegistration.SendKeys("123");

            Thread.Sleep(1000);

            var passwordRegistration = driver.FindElement(By.Id("passwd"));
            passwordRegistration.SendKeys("aa");

            Thread.Sleep(1000);


            var adressRegistration = driver.FindElement(By.Id("address1"));
            adressRegistration.SendKeys("Sofia, Mladost 1");


            Thread.Sleep(1000);

            var cityRegistration = driver.FindElement(By.Id("city"));
            cityRegistration.SendKeys("Sofia");

            Thread.Sleep(1000);

            var postalCodeRegistration = driver.FindElement(By.Id("postcode"));
            postalCodeRegistration.SendKeys("a");

            Thread.Sleep(2000);

            var phoneMobileRegistration = driver.FindElement(By.Id("phone_mobile"));
            phoneMobileRegistration.SendKeys("a1a2");

            Thread.Sleep(2000);

            var registrationButton = driver.FindElement(By.CssSelector("#submitAccount > span"));
            registrationButton.Click();

            
            
        }

       
        [TearDown]

        public void TearDown()
        {

        }

    }
}