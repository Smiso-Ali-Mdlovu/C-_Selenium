using System;
using FirstSeleniumWithCSharp.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstSeleniumWithCSharp.Utils
{
	public class BaseTest
	{

        public static IWebDriver _driver;
        private string DriverPath { get; set; } = @"C:/Users/smiso/Documents/chromedriver";
        private string BaseUrl { get; set; } = "https://www.NBA.com";

        [SetUp]
        public void SetUp()
        {
            _driver = GetChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            // Maximize the browser window
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(BaseUrl);
            HomePage hp = new();
            hp.AcceptCookie();
            
        }

   


        [TearDown]
        public void TearDown()
        {
           // _driver.Quit();
        }

        private WebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            //options.AddArguments("--headless");

            return new ChromeDriver(DriverPath, options, TimeSpan.FromSeconds(300));
        }

        
    }
}

