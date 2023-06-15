using System;
using AngleSharp.Dom;
using FirstSeleniumWithCSharp.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace FirstSeleniumWithCSharp.Pages
{
	public class Store : BaseTest
    {
        
        
        

        [FindsBy(How = How.XPath, Using = "//a[@id='1']")]
        private IWebElement _MEN;

        [FindsBy(How = How.XPath, Using = "//a[@id='2']")]
        private IWebElement _WOMEN;

        [FindsBy(How = How.XPath, Using = "//a[@id='3']")]
        private IWebElement _KIDS;

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[8]/div[1]/div[1]/nav[1]/div[2]/div[2]/div[3]/div[2]/ul[1]/li[5]/a[1]")]
        private IWebElement _SaleItem;


        [FindsBy(How = How.XPath, Using = "//body/div[3]/div[2]/div[1]/button[1]/span[2]/i[1]")]
        private IWebElement _DismisPopup;

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Your Selections')]")]
        private IWebElement _YourSelectionTest;

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[8]/div[1]/div[1]/nav[1]/div[2]/div[1]/div[1]/ul[1]/li[1]/a[1]/span[1]")]
        private IWebElement _MenSelection;


        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[8]/div[1]/div[1]/nav[1]/div[2]/div[1]/div[1]/ul[1]/li[1]/a[1]/span[1]")]
        private IWebElement _WomenenSelection;

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[8]/div[1]/div[1]/nav[1]/div[2]/div[1]/div[1]/ul[1]/li[2]/a[1]/span[1]")]
        private IWebElement _SaleItemsSelection;


        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[8]/div[1]/div[1]/nav[1]/div[2]/div[1]/div[1]/ul[1]/li[1]/a[1]/span[1]")]
        private IWebElement _KidSelection;



        public Store()
        {
      
            PageFactory.InitElements(_driver, this);
        }

        

        public void AtalantaMen()
        {

            //SelectElement dropDown = new(_MEN);
            //dropDown.SelectByText("Atalanta Hawks");
            _MEN.Click();
        }

        public void AtalantaWomen()
        {

            SelectElement dropDown = new(_WOMEN);
            dropDown.SelectByText("Atalanta Hawks");
        }

        public void AtalantaKids()
        {

            SelectElement dropDown = new(_KIDS);
            dropDown.SelectByText("Atalanta Hawks");
        }

        public void ScrollToSaleItemAndClick()
        {
            // Scroll to the element
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _SaleItem);
            _SaleItem.Click();
        }

        public void ScrolltoYourSelection()
        {
            // Scroll to the element
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _YourSelectionTest);
            
        }

        public void VerifyMenItems()
        {
            if(_MenSelection.Displayed)
            {
                Assert.That(_MenSelection.Text, Is.EqualTo("Men"));
            }
        }

        public void VerifyWomensItems()
        {
            if (_WomenenSelection.Displayed)
            {
                Assert.That(_WomenenSelection.Text, Is.EqualTo("Women"));
            }
        }

        public void VerifyKidsItems()
        {
            if (_KidSelection.Displayed)
            {
                Assert.That(_KidSelection.Text, Is.EqualTo("Kids"));
            }
        }

        public void VerifySaleItems()
        {
            if (_SaleItemsSelection.Displayed)
            {
                Assert.That(_SaleItemsSelection.Text, Is.EqualTo("Sale Items"));
            }
        }

        public void DismisPopup()
        {
            IWebElement closeButton = _driver.FindElement(By.CssSelector("body:nth-child(2) div.modal.sliver-modal:nth-child(27) > div.modal-backdrop"));
            closeButton.Click();
        }


        
    }
}

