﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.Utilities
{
    public static class SeleniumExtensionMethods
    {
        static int globalWait = 60;
        //Writes out to the console either stack trace or general logging information
        public static void logMe(this IWebElement element, Exception ex = null)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            if (ex == null)
            {
                Console.WriteLine("(" + element.GetAttribute("value") + " " + element.Text + ")");
            }
            else
            {
                Console.WriteLine("Exception: " + sf.ToString());
            }
        }

        //Grabs the name of the method processing the request
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCurrentMethod()
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);


            return sf.GetMethod().Name;
        }
        public static void EnterText(this IWebElement element, string value)
        {
            WebDriverWait wait = new WebDriverWait(SeleniumWebDriver.driver, TimeSpan.FromSeconds(globalWait));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            logMe(element);
            element.SendKeys(value);
        }
        public static void WaitAndClick(this IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(SeleniumWebDriver.driver, TimeSpan.FromSeconds(globalWait));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            logMe(element);
            element.Click();

        }
        public static void SelectFromDropDownListByText(this IWebElement element, string value)
        {
            WebDriverWait wait = new WebDriverWait(SeleniumWebDriver.driver, TimeSpan.FromSeconds(globalWait));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            logMe(element);
            if (!value.Equals(""))
            {
                SelectElement selectElement = new SelectElement(element);
                selectElement.SelectByText(value);
            }
        }
    }
}