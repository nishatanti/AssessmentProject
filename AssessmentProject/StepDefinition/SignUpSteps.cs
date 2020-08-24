using AssessmentProject.PageObject;
using AssessmentProject.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace AssessmentProject
{
    [Binding]
    public sealed class SignUpSteps
    {
        //IWebDriver _driver;
        private IWebDriver _driver;
        SignUpRepo signup ;
        Support supp = new Support();

        public SignUpSteps(IWebDriver driver)
        {
            _driver = driver;
            signup = new SignUpRepo(_driver);
        }

        

        [Given(@"User is on Signup Page")]
        public void GivenUserIsOnSignupPage()
        {
            //signup = new SignUpRepo(_driver);
            _driver.Navigate().GoToUrl("http://jt-dev.azurewebsites.net/#/SignUp");
            //_driver.Manage().Window.Maximize();
        }

        [When(@"Click on language dropdown")]
        public void WhenClickOnLanguageDropdown()
        {
           
            signup.Language();
            
        }

        [When(@"Select English language from dropdown")]
        public void WhenSelectEnglishLanguageFromDropdown()
        {
            
            signup.selectEnglishLanguage();
            
        }

        [Then(@"All the details of page comes in English language")]
        public void ThenAllTheDetailsOfPageComesInEnglishLanguage()
        {
            signup = new SignUpRepo(_driver);
            Boolean Display = _driver.FindElement(By.CssSelector("#content > div > div.main-body > div > section > div.form-container")).Displayed;
            Console.WriteLine("Element displayed is :" + Display);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Close();
            _driver.Quit();
        }

        [When(@"Select Dutch language from dropdown")]
        public void WhenSelectDutchLanguageFromDropdown()
        {
            
            signup.selectDutchLanguage();
        }

        [Then(@"All the details of page comes in dutch language")]
        public void ThenAllTheDetailsOfPageComesInDutchLanguage()
        {
            signup = new SignUpRepo(_driver);
            Boolean Display = _driver.FindElement(By.CssSelector("#content > div > div.main-body > div > section > div.form-container")).Displayed;
            Console.WriteLine("Element displayed is :" + Display);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Close();
            _driver.Quit();
        }

        [Given(@"Select language from dropdown")]
        public void GivenSelectLanguageFromDropdown()
        {
            
            signup.Language();
        }

        [When(@"Enter name, organisation and email address")]
        public void WhenEnterNameOrganisationAndEmailAddress()
        {
           
            signup.Name();
            signup.OrgName();
            signup.Email();
        }

        [When(@"Select I agree option")]
        public void WhenSelectIAgreeOption()
        {
           
            signup.IAgree();
        }

        [When(@"Click on signup button")]
        public void WhenClickOnSignupButton()
        {
            
            signup.ClickSubmit();
        }

        [Then(@"A validation message of welcome appear on the page")]
        public void ThenAValidationMessageOfWelcomeAppearOnThePage()
        {
            
            try
            {
                signup = new SignUpRepo(_driver);
                IWebElement show = _driver.FindElement(By.CssSelector("#content > div > div.main-body > div > section > div.form-container > form > div"));
                Console.WriteLine(show.Displayed);
                Thread.Sleep(3000);
                _driver.Close();
                _driver.Quit();
            }
            catch (Exception)
            {
                signup = new SignUpRepo(_driver);
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                Assert.That(_driver.PageSource.Contains("A welcome email has been sent. Please check your email"), Is.EqualTo(true), "The text doesnot exist");
                
                _driver.Close();
                _driver.Quit();
            }
        }

        [Given(@"User is on yahoomail page")]
        public void GivenUserIsOnYahoomailPage()
        {
           
            _driver.Navigate().GoToUrl("https://login.yahoo.com/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [When(@"Enter username and password")]
        public void WhenEnterUsernameAndPassword()
        {
            
            signup.yahoouname();
            signup.usernxtbtn();
            signup.yahoopwd();
        }

        [When(@"Click on next button")]
        public void WhenClickOnNextButton()
        {
            
            signup.Pwdnxtbtn();
            Thread.Sleep(5000);
            By id = By.Id("header-mail-button");
            supp.ExplicitWaitElement2(5, _driver, id);
            _driver.FindElement(By.Id("header-mail-button")).Click();
        }

  

        [When(@"Userlogged in sucessfully")]
        public void WhenUserloggedInSucessfully()
        {           
                
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
               

            try
            {            
                IWebElement ele = _driver.FindElement(By.Id("ybar-inner-wrap"));
                Console.WriteLine(ele.Displayed);
            }
            catch (NoSuchElementException )
            {
                Console.WriteLine("element does not exist");             
            }
        }
      
        [Then(@"JabaTalks mail should appear inside the inbox")]
        public void ThenJabaTalksMailShouldAppearInsideTheInbox()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Assert.That(_driver.PageSource.Contains("JabaTalks"), Is.EqualTo(true), "The text jabatalks doesnot exist");
           
            _driver.Close();
            _driver.Quit();
        }

    }
}
