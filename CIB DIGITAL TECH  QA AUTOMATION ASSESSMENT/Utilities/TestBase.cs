using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.Utilities
{
    public class TestBase
    {
        [SetUp]
        public void Initialize()
        {
            SeleniumWebDriver.driver = new ChromeDriver();
            SeleniumWebDriver.driver.Navigate().GoToUrl("http://www.way2automation.com/angularjs-protractor/webtables/");
            SeleniumWebDriver.driver.Manage().Window.Maximize();
            SeleniumWebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            string projectPath = System.Reflection.Assembly.GetCallingAssembly().Location;
            string path = Path.GetFullPath(projectPath + @"..\..\..\..\..\..\TestData");
            ExcelLib.PopulateInCollection(path + @"\UserDetails.xlsx");
        }

        [TearDown]
        public void CleanUp()
        {
            SeleniumWebDriver.driver.Close();
        }
    }
}
