using System;
using FirstSeleniumWithCSharp.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FirstSeleniumWithCSharp.Pages
{
	public class Stats : BaseTest
	{

        [FindsBy(How = How.XPath, Using = "//body/div[@id='__next']/div[2]/div[2]/div[3]/div[1]/div[1]/section[1]/div[1]/div[2]/button[1]")]
        private IWebElement _DailyLeader;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='__next']/div[2]/div[2]/div[3]/div[1]/div[1]/section[1]/div[1]/div[2]/button[2]")]
        private IWebElement _SeasonLeader;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/section[1]/div[1]/div[4]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/a[1]")]
        private IWebElement _DailyLeaderName;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/section[1]/div[1]/div[4]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/a[1]")]
        private IWebElement _SeasonLeaderPostperGame;

        
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'See All Player Stats')]")]
        private IWebElement _AllPlayerStats;

        

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Nikola Jokic')]")]
        private IWebElement _AllPlayerStatsNo1;


        public Stats()
		{
            PageFactory.InitElements(_driver, this);
        }

        public void ClickDL()
        {
            _DailyLeader.Click();
        }

        public void ClickSL()
        {
            _SeasonLeader.Click();
        }

        public void VerifyDLName()
        {
            if (_DailyLeaderName.Displayed)
            {
                Assert.That(_DailyLeaderName.Text, Is.EqualTo("Nikola Jokic"));
            }
        }

        public void VerifySLName()
        {
            if (_SeasonLeaderPostperGame.Displayed)
            {
                Assert.That(_SeasonLeaderPostperGame.Text, Is.EqualTo("Devin Booker"));
            }
        }

        public void ClickAllPlayerStat()
        {
            _AllPlayerStats.Click();
        }

        public void VerifyAllPlayerStatNo1()
        {
            if (_AllPlayerStatsNo1.Displayed)
            {
                Assert.That(_AllPlayerStatsNo1.Text, Is.EqualTo("Nikola Jokic"));
            }
        }

        

    }
}

