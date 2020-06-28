using CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.Utilities;
using CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.WebAutomation.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.WebAutomation.TestExecution
{
    class ExecuteTask2TestClass : TestBase
    {
        
        [TestCase("FName1", "LName1", "User1", "Pass1", "Company AAA", "Admin", "admin@gmail.com", "082555")]
        public void ExecuteAddUserTestCase(string name, 
                                           string lastName, 
                                           string username,
                                           string password,
                                           string company,
                                           string role, 
                                           string email,
                                           string cell)
        {
            UserTablePageObjects userTablePageObjects = new UserTablePageObjects();
            AddUserPageObjects addUserPageObjects = userTablePageObjects.ClickAddUsers("");
            addUserPageObjects.AddUser(name, lastName, username, password, company, role, email,cell);
        }
    }
}
