using System;
using FirstSeleniumWithCSharp.Pages;
using FirstSeleniumWithCSharp.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstSeleniumWithCSharp.TestCases
{
	public class AtalantaHawksSaleItems : BaseTest
	{

        [Test]
		public void MaleSale()
		{
            // Create an instance of the Store class
            Store store = new();

            // Create an instance of the Store class
            HomePage home_page = new();

            home_page.ClickStoreTab();
            store.DismisPopup();
            store.AtalantaMen();
            store.ScrollToSaleItemAndClick();
            store.ScrolltoYourSelection();
            store.VerifyMenItems();
            store.VerifySaleItems();
        }

        [Test]
        public void FemaleSale()
		{
            // Create an instance of the Store class
            Store store = new();

            // Create an instance of the Store class
            HomePage home_page = new();
            home_page.ClickStoreTab();
            store.DismisPopup();
            store.AtalantaWomen();
            store.ScrollToSaleItemAndClick();
            store.ScrolltoYourSelection();
            store.VerifyWomensItems();
            store.VerifySaleItems();
        }

        [Test]
        public void Kids()
		{
            // Create an instance of the Store class
            Store store = new();

            // Create an instance of the Store class
            HomePage home_page = new();


            store.DismisPopup();
            home_page.ClickStoreTab();
            store.AtalantaKids();
            store.ScrollToSaleItemAndClick();
            store.ScrolltoYourSelection();
            store.VerifyKidsItems();
            
        }
	}
}

