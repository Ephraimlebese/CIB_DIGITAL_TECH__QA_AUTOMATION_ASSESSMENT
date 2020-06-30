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
        public IWebElement smartTable => SeleniumWebDriver.driver.FindElement(By.XPath("//table[@table-title='Smart Table example']"));

        public void validateUserPage()
        {
            bool userTable = smartTable.IsDisplayed();
            Assert.IsTrue(userTable);
        }
        public void ConfirmUser(string name)
        {
            bool user = SeleniumExtensionMethods.PageContainsText(name);
            Assert.IsTrue(user);
        }
        public AddUserPageObjects ClickAddUsers()
        {
            validateUserPage();
            btnAddUsers.WaitAndClick();
            return new AddUserPageObjects();
        }

    }
}
