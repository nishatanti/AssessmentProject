using AssessmentProject.Utility;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssessmentProject.PageObject
{
    class SignUpRepo
    {
        
        private IWebDriver _driver;
        Support supp = new Support();

        public SignUpRepo(IWebDriver driver)
        {
            
            PageFactory.InitElements(driver, this);
            this._driver = driver;
        }

        
        
        [FindsBy(How = How.XPath, Using = "//div[@id='language']")]
        public IWebElement SelectLanguage { get; set; }
        public void Language()
        {
            SelectLanguage.Click();

        }

        [FindsBy(How = How.Id, Using = "ui-select-choices-row-1-0")]

        public IWebElement SelectEnglish { get; set; }
        public void selectEnglishLanguage()
        {
            SelectEnglish.Click();
            
        }

        [FindsBy(How = How.Id, Using = "ui-select-choices-row-1-1")]
        public IWebElement SelectDutch { get; set; }
        public void selectDutchLanguage()
        {
            SelectDutch.Click();
            
        }

        [FindsBy(How = How.Id, Using = "name")]

        public IWebElement EnterName { get; set; }
        public void Name()
        {
            EnterName.SendKeys("Nisha");
        }

        [FindsBy(How = How.Id, Using = "orgName")]

        public IWebElement EnterOrg { get; set; }
        public void OrgName()
        {
            EnterOrg.SendKeys("Nisha");
        }

        [FindsBy(How = How.Id, Using = "singUpEmail")]

        public IWebElement Enteremail { get; set; }
        public void Email()
        {
            Enteremail.SendKeys("sharma.aditi95@yahoo.com");
        }



        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[3]/div/section/div[1]/form/fieldset/div[4]/label/span")]

        public IWebElement SelectCheckbox { get; set; }
        public void IAgree()
        {
            try { SelectCheckbox.Click(); }
            catch (Exception) { SelectCheckbox.Click(); Console.WriteLine("Error"); }

        }

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[3]/div/section/div[1]/form/fieldset/div[5]/button")]

        public IWebElement ClickGetStared { get; set; }
        public void ClickSubmit()
        {
            ClickGetStared.Click();
        }

        [FindsBy(How = How.Id, Using = "login-username")]

        public IWebElement Yahoouser { get; set; }
        public void yahoouname()
        {
            Yahoouser.SendKeys("sharma.aditi95@yahoo.com");
        }

        [FindsBy(How = How.Id, Using = "login-signin")]

        public IWebElement Usernxtbtn { get; set; }
        public void usernxtbtn()
        {
            Usernxtbtn.Click();
        }

        [FindsBy(How = How.Id, Using = "login-passwd")]

        public IWebElement Yahoopwd { get; set; }
        public void yahoopwd()
        {
            //supp.EncodingPassword();
            //Yahoopwd.SendKeys("encodedPassword");
            Yahoopwd.SendKeys("Welcome@123");
            //V2VsY29tZUAxMjM =
        }

        [FindsBy(How = How.Name, Using = "verifyPassword")]

        public IWebElement VerifyPwd { get; set; }
        public void Pwdnxtbtn()
        {
            VerifyPwd.Click();
        }
    }

   
}
