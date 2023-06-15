using System;
using FirstSeleniumWithCSharp.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace FirstSeleniumWithCSharp.Pages
{
	public class HomePage : BaseTest
	{
        

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Players')]")]
        private  IWebElement _playerTab;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='__next']/div[2]/div[1]/div[1]/nav[1]/ul[1]/li[15]/a[1]/span[1]")]
        private  IWebElement _store;

        [FindsBy(How = How.Id, Using = "onetrust-accept-btn-handler")]
        private IWebElement _acceptCookie;

        
        [FindsBy(How = How.XPath, Using = "//body/div[@id='__next']/div[2]/div[1]/div[1]/nav[1]/ul[1]/li[7]/a[1]/span[1]")]
        private IWebElement _statsTab;


        public HomePage()
        {
           
            PageFactory.InitElements(_driver, this);

        }

        public void AcceptCookie()
        {
            _acceptCookie.Click();
        }


        public void ClickPlayersTab()
        {
            _playerTab.Click();
        }

        public void ClickStoreTab()
        {
            _store.Click();
        }

        public void ClickStatsTab()
        {
            _statsTab.Click();
        }
    }
}

