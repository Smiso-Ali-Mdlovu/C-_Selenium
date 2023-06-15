using System;
using FirstSeleniumWithCSharp.Pages;
using FirstSeleniumWithCSharp.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstSeleniumWithCSharp.TestCases
{
	public class SearchPlayer : BaseTest
    {
         

        [Test]
		public void GurdAlabama()
		{
            
            // Create an instance of the Players class
            Players players = new();

            // Create an instance of the HomePage class
            HomePage home_page = new();

            home_page.ClickPlayersTab();
           
            players.SelectGurd();
            players.SelectAlabama();
            players.VerifyFirstGuardPlayer();
            players.VerifySecondGuardPlayer();

        }

        [Test]
        public void ForwardArizonaState()
        {
            // Create an instance of the Players class
            Players players = new();

            // Create an instance of the HomePage class
            HomePage home_page = new();

            home_page.ClickPlayersTab();
            
            players.SelecForward();
            players.SelectArizona();
            players.VerifyFirstForwardPlayer();
            players.VerifySecondForwardPlayer();
        }
    }
}

