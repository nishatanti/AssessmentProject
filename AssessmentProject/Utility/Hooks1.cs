﻿using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AssessmentProject.Utility
{
    [Binding]
    public sealed class Hooks1
    {      
        private readonly IObjectContainer _objectcontainer;

        private IWebDriver _driver;

        public Hooks1(IObjectContainer objectcontainer)
        {
            _objectcontainer = objectcontainer;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("LAUNCH URL");
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            ChromeDriver _driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            _driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));
            //_driver = new ChromeDriver();
            _objectcontainer.RegisterInstanceAs<IWebDriver>(_driver);
           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("TEST PASS");
            //_driver.Close();
            //_driver.Quit();
        }

        public IWebDriver Driver => _driver;
    }
}
