using System;
using FirstSeleniumWithCSharp.Pages;
using FirstSeleniumWithCSharp.Utils;

namespace FirstSeleniumWithCSharp.TestCases
{
	public class PlayerStats : BaseTest
	{
		[Test]
		public void DailyLeader()
		{
            // Create an instance of the Stats class
            Stats stats = new();


            //Create an instance of the Stats class
            HomePage home_page = new ();

            home_page.ClickStatsTab();
            stats.ClickDL();
            stats.VerifyDLName();


		}

        [Test]
        public void SeasonLeader()
		{

            //Create an instance of the Stats class
            Stats stats = new ();


            //Create an instance of the Stats class
            HomePage home_page = new();

            home_page.ClickStatsTab();
            stats.ClickSL();
            stats.VerifySLName();

        }

        [Test]
        public void AllPlayerStat()
		{
            //Create an instance of the Stats class
            Stats stats = new();


            //Create an instance of the Stats class
            HomePage home_page = new();

            home_page.ClickStatsTab();
            stats.ClickAllPlayerStat();
            stats.VerifyAllPlayerStatNo1();

        }
	}
}

