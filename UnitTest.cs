using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;


namespace HudlHomework
{
    public class HudlLoginPageTests
    {
        private WebDriver WebDriver { get; set; } = null!;
        private string DriverPath { get; set; } = @"LocalAddressForChromeDriver";
        private string LoginPage { get; set; } = "https://www.hudl.com/login";
        private string HomePage { get; set; } = "https://www.hudl.com/";


        [SetUp]
        public void Setup()
        {
            WebDriver = GetChromeDriver();
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }

        private WebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();

            return new ChromeDriver(DriverPath, options, TimeSpan.FromSeconds(300));
        }

        string UserEmail = "EmailAddressYouWantToUse";
        string UserPassword = "PasswordYouWantToUse";
        string testingId = "";

        public void NavigateToHomePage()
        {
            WebDriver.Navigate().GoToUrl(HomePage);
            Assert.AreEqual("Hudl • Tools to help every team, coach and athlete improve", WebDriver.Title);
        }
        public void NavigateToLoginPage()
        {
            WebDriver.Navigate().GoToUrl(LoginPage);
            Assert.AreEqual("Log In", WebDriver.Title);
        }

        public void ClickLoginWithOrganization()
        {
            testingId = "log-in-with-organization-btn";
            var input = WebDriver.FindElement(By.CssSelector("[data-qa-id='" + testingId + "']"));
            input.Click();
            Thread.Sleep(5000);
            Assert.AreEqual("Log In with Organization - Hudl", WebDriver.Title);
        }

        public void ClickNeedHelp()
        {
            testingId = "need-help-link";
            var input = WebDriver.FindElement(By.CssSelector("[data-qa-id='" + testingId + "']"));
            input.Click();
            Thread.Sleep(5000);
            Assert.AreEqual("Log In", WebDriver.Title);
        }

        public void ClickHomePageHeaderLogin()
        {
            testingId = "login";
            var input = WebDriver.FindElement(By.CssSelector("[data-qa-id='" + testingId + "']"));
            input.Click();
            Thread.Sleep(5000);
            Assert.AreEqual("Log In", WebDriver.Title);
        }

        public void EnterEmailAddress()
        {
            var input = WebDriver.FindElement(By.Id("email"));
            input.Clear();
            input.SendKeys(UserEmail);
        }

        public void EnterPassword()
        {
            var input = WebDriver.FindElement(By.Id("password"));
            input.Clear();
            input.SendKeys(UserPassword);
        }

        public void ClickLoginButton()
        {
            var input = WebDriver.FindElement(By.Id("logIn"));
            input.Click();
            Thread.Sleep(5000);
            Assert.AreEqual("Home - Hudl", WebDriver.Title);
        }

        public void ClickSignUpButton()
        {
            var input = WebDriver.FindElement(By.LinkText("Sign up"));
            input.Click();
            Thread.Sleep(5000);
            Assert.AreEqual("Sign up for Hudl", WebDriver.Title);
        }

        public void ClickRememberMeButton()
        {
            testingId = "remember-me-checkbox-label";
            var input = WebDriver.FindElement(By.CssSelector("[data-qa-id='" + testingId + "']"));
            input.Click();
            Thread.Sleep(5000);
        }

        public void ClickLogOutButton()
        {
            testingId = "27";
            var input = WebDriver.FindElement(By.CssSelector("[data-reactid='" + testingId + "']"));
            input.Click();
            testingId = "34";
            input = WebDriver.FindElement(By.CssSelector("[data-reactid='" + testingId + "']"));
            input.Click();
            Thread.Sleep(5000);
            Assert.AreEqual("Hudl • Tools to help every team, coach and athlete improve", WebDriver.Title);
        }

        public void AssertWrongCredentials()
        {
            testingId = "error-display";
            var input = WebDriver.FindElement(By.CssSelector("[data-qa-id='" + testingId + "']"));
            Assert.AreEqual("error-display", testingId);
            Thread.Sleep(5000);
        }

        [Test]
        public void HomePageLoginButtonWorks()
        {
            NavigateToHomePage();
            ClickHomePageHeaderLogin();
            TearDown();
        }

        [Test]
        public void RememberMeCheckboxWorks()
        {
            NavigateToLoginPage();
            ClickRememberMeButton();
            TearDown();
        }

        
        [Test]
        public void SuccessfulyLogOut()
        {
            NavigateToLoginPage();
            EnterEmailAddress();
            EnterPassword();
            ClickLoginButton();
            ClickLogOutButton();
            TearDown();
        }

        [Test]
        public void SignUpButtonWorks()
        {
            NavigateToLoginPage();
            ClickSignUpButton();
            TearDown();
        }

        [Test]
        public void NeedHelpButtonWorks()
        {
            NavigateToLoginPage();
            ClickNeedHelp();
            TearDown();
        }

        [Test]
        public void SuccessfulLogin()
        {
            NavigateToLoginPage();
            EnterEmailAddress();
            EnterPassword();
            ClickLoginButton();
            Assert.AreEqual("Home - Hudl", WebDriver.Title);
            TearDown();
        }

        [Test]
        public void LoginWithOrganization()
        {
            NavigateToLoginPage();
            ClickLoginWithOrganization();
            TearDown();
        }

        [Test]
        public void IncorrectEmail()
        {
            NavigateToLoginPage();

            var input = WebDriver.FindElement(By.Id("email"));
            input.Clear();
            input.SendKeys("wrongemail.com");

            EnterPassword();
            ClickLoginButton();
            AssertWrongCredentials();
            TearDown(); 
        }

        [Test]
        public void IncorrectPassword()
        {
            NavigateToLoginPage();
            EnterEmailAddress();

            var input = WebDriver.FindElement(By.Id("password"));
            input.Clear();
            input.SendKeys("wrongpassword");

            ClickLoginButton();
            AssertWrongCredentials();
            TearDown();
        }

    }
}