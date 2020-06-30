using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace CIB_DIGITAL_TECH__QA_AUTOMATION_ASSESSMENT.Utilities
{
    public static class SeleniumExtensionMethods
    {
        static int globalWait = 60;
        static string projectPath = System.Reflection.Assembly.GetCallingAssembly().Location;
        static string path = Path.GetFullPath(projectPath + @"..\..\..\..\..\..\TestEvidance");
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
        public static string TakeScreenshot(string ScreenshotName)
        {
            string screenshotPath = Path.Combine(path + @"\" + ScreenshotName);
            ITakesScreenshot ssdriver = SeleniumWebDriver.driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
            return screenshotPath;
        }
        public static bool IsDisplayed(this IWebElement element)
        {

            bool result;
            try
            {

                result = element.Displayed;
                logMe(element);
            }
            catch (Exception ex)
            {
                result = false;
                logMe(element, ex);
            }
            return result;
        }
        public static bool PageContainsText(string text)
        {
            Thread.Sleep(3000);
            if (!SeleniumWebDriver.driver.PageSource.Contains(text))
            {
                return false;
            }

            return true;
        }
    }
}
