using CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.WebAutomation.PageObjects
{
    class AddUserPageObjects
    {

        public AddUserPageObjects()
        {

        }

        public IWebElement txtFirstName => SeleniumWebDriver.driver.FindElement(By.Name("FirstName"));
        public IWebElement txtLastName => SeleniumWebDriver.driver.FindElement(By.Name("LastName"));
        public IWebElement txtUserName => SeleniumWebDriver.driver.FindElement(By.Name("UserName"));
        public IWebElement txtPassword => SeleniumWebDriver.driver.FindElement(By.Name("password"));
        public IWebElement rdbComapnyBBB(string company) => SeleniumWebDriver.driver.FindElement(By.XPath("//label[text()='"+company+"']"));
        public IWebElement ddlRole => SeleniumWebDriver.driver.FindElement(By.Name("RoleId"));
        public IWebElement txtEmail => SeleniumWebDriver.driver.FindElement(By.Name("Email"));
        public IWebElement txtCellPhone => SeleniumWebDriver.driver.FindElement(By.Name("Mobilephone"));
        public IWebElement btnSave => SeleniumWebDriver.driver.FindElement(By.Name("//button[text()='Save']"));

        public void AddUser(string name, 
                            string lastaName, 
                            string userName, 
                            string password, 
                            string company,
                            string role, 
                            string email, 
                            string cell)
        {
            txtFirstName.EnterText(name);
            txtLastName.EnterText(lastaName);
            txtUserName.EnterText(userName);
            txtPassword.EnterText(password);
            rdbComapnyBBB(company).WaitAndClick();
            ddlRole.SelectFromDropDownListByText(role);
            txtEmail.EnterText(email);
            txtCellPhone.EnterText(cell);
            btnSave.WaitAndClick();
        }
    }
}
