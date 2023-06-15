using System;
using AngleSharp.Dom;
using FirstSeleniumWithCSharp.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace FirstSeleniumWithCSharp.Pages
{
	public class Players : BaseTest 
	{
  
       
        [FindsBy(How = How.XPath, Using = "//body/div[@id='__next']/div[2]/div[2]/main[1]/div[2]/section[1]/div[1]/div[2]/div[1]/div[3]/label[1]/div[1]/select[1]")]
        private IWebElement _position;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='__next']/div[2]/div[2]/main[1]/div[2]/section[1]/div[1]/div[2]/div[1]/div[4]/label[1]/div[1]/select[1]")]
        private IWebElement _college;

        //Guards

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'JD')]")]
        private IWebElement _JD;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Davison')]")]
        private IWebElement _Davison;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Keon')]")]
        private IWebElement _Keon;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Ellis')]")]
        private IWebElement _Ellis;

        //Forwards


        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Aaron')]")]
        private IWebElement _Aaron;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Gordon')]")]
        private IWebElement _Gordon;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Andre')]")]
        private IWebElement _Andre;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Iguodala')]")]
        private IWebElement _Iguodala;


        public Players()
        {
          
            PageFactory.InitElements(_driver, this);
        }

        

        public void SelectGurd()
        {
            SelectElement dropDown = new(_position);
            dropDown.SelectByText("Guard");
        }

        public void SelecForward()
        {
            SelectElement dropDown = new(_position);
            dropDown.SelectByText("Forward");
        }

        public void SelectAlabama()
        {
            SelectElement dropDown = new(_college);
            dropDown.SelectByText("Alabama");
            
        }

        public void SelectArizona()
        {
            SelectElement dropDown = new(_college);
            dropDown.SelectByText("Arizona");
        }

        public void VerifyFirstGuardPlayer()
        {
            if (_JD != null)
            {
                Console.WriteLine("" + _JD.Text + "is present in the DOM.");
                Assert.That(_JD.Text, Is.EqualTo("JD"));
            }
            if (_Davison != null)
            {
                Console.WriteLine("" + _Davison.Text + "is present in the DOM.");
                Assert.That(_Davison.Text, Is.EqualTo("Davison"));   

            }

        }

        public void VerifySecondGuardPlayer()
        {
            if (_Keon != null)
            {
                Console.WriteLine("" +_Keon.Text + "is present in the DOM.");
                Assert.That(_Keon.Text, Is.EqualTo("Keon"));
            }
            if (_Ellis != null)
            {
                Console.WriteLine(""+ _Ellis.Text+"is present in the DOM.");
                Assert.That(_Ellis.Text, Is.EqualTo("Ellis"));
            }

        }

        public void VerifyFirstForwardPlayer()
        {
            if (_Aaron != null)
            {
                Console.WriteLine("" + _Aaron.Text + "is present in the DOM.");
                Assert.That(_Aaron.Text, Is.EqualTo("Aaron"));
            }
            if (_Gordon != null)
            {
                Console.WriteLine("" + _Gordon.Text + "is present in the DOM.");
                Assert.That(_Gordon.Text, Is.EqualTo("Gordon"));
            }

        }

        public void VerifySecondForwardPlayer()
        {
            if (_Andre != null)
            {
                Console.WriteLine("" + _Andre.Text + "is present in the DOM.");
                Assert.That(_Andre.Text, Is.EqualTo("Andre"));
            }
            if (_Iguodala != null)
            {
                Console.WriteLine("" + _Iguodala.Text + "is present in the DOM.");
                Assert.That(_Iguodala.Text, Is.EqualTo("Iguodala"));
            }

        }
    }
}

