using CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.WebAutomation.PageObjects
{
    class UserTablePageObjects
    {

        public UserTablePageObjects()
        {

        }

        public IWebElement btnAddUsers => SeleniumWebDriver.driver.FindElement(By.XPath("//button[text()=' Add User']"));

        public void validateUserPage(string expectedUrl)
        {
            string url = SeleniumWebDriver.driver.Url;
            Assert.AreEqual(expectedUrl,url);
        }
        public AddUserPageObjects ClickAddUsers(string url)
        {
            validateUserPage(url);
            btnAddUsers.WaitAndClick();
            return new AddUserPageObjects();
        }
    }
}
