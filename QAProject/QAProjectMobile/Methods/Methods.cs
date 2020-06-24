using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace QAProjectMobile.Methods
{
    public class Methods
    {
        public static void OpenPage(AndroidDriver<AppiumWebElement> driver, string url, int timeInSeconds)
        {            
            driver.Url = url;                        
            Thread.Sleep(timeInSeconds* 1000);
        }

        public static void GoToPage(AndroidDriver<AppiumWebElement> driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(2000);
        }

        public static void MoveToElement(AndroidDriver<AppiumWebElement> webDriver, string elementName, int timeInSeconds)
        {
            var element = webDriver.FindElementByCssSelector(elementName);
            Actions actions = new Actions(webDriver);
            actions.MoveToElement(element);
            actions.Perform();
            Thread.Sleep(timeInSeconds * 1000);
        }

        public static void ClickOnElement(AndroidDriver<AppiumWebElement> webDriver, string by, string elementName, int timeInseconds)
        {
            switch (by)
            {
                case "id":
                    webDriver.FindElementById(elementName).Click();
                    break;
                case "xPath":
                    webDriver.FindElementByXPath(elementName).Click();
                    break;
                case "cssSelector":
                    webDriver.FindElementByCssSelector(elementName).Click();
                    break;
                case "name":
                    webDriver.FindElementByName(elementName).Click();
                    break;
                case "className":
                    webDriver.FindElementByClassName(elementName).Click();
                    break;
                case "linkText":
                    webDriver.FindElementByLinkText(elementName).Click();
                    break;
            }

            Thread.Sleep(timeInseconds * 1000);
        }

        public static void InputOnElement(AndroidDriver<AppiumWebElement> webDriver, string by, string elementName, string inputText, int timeInSeconds)
        {
            switch (by)
            {
                case "id":                    
                    webDriver.FindElementById(elementName).SendKeys(inputText);
                    break;
                case "xPath":
                    webDriver.FindElementByXPath(elementName).SendKeys(inputText);
                    break;
                case "cssSelector":
                    webDriver.FindElementByCssSelector(elementName).SendKeys(inputText);
                    break;
                case "name":
                    webDriver.FindElementByName(elementName).SendKeys(inputText);
                    break;
                case "className":
                    webDriver.FindElementByClassName(elementName).SendKeys(inputText);
                    break;
            }

            Thread.Sleep(timeInSeconds * 1000);
        }

        public static void ClearTextElement(AndroidDriver<AppiumWebElement> webDriver, string by, string elementName, int timeInSeconds)
        {
            switch (by)
            {
                case "id":                    
                    webDriver.FindElementById(elementName).Clear();
                    break;
                case "xPath":
                    webDriver.FindElementByXPath(elementName).Clear();
                    break;
                case "cssSelector":
                    webDriver.FindElementByCssSelector(elementName).Clear();
                    break;
                case "name":
                    webDriver.FindElementByName(elementName).Clear();
                    break;
                case "className":
                    webDriver.FindElementByClassName(elementName).Clear();
                    break;
            }

            Thread.Sleep(timeInSeconds * 1000);
        }

        public static string GetValueFromElement(AndroidDriver<AppiumWebElement> webDriver, string by, string elementName, int timeInseconds)
        {
            string elementText = "";
            switch (by)
            {
                case "id":
                    elementText = webDriver.FindElementById(elementName).GetAttribute("value");
                    break;
                case "xPath":
                    elementText = webDriver.FindElementByXPath(elementName).GetAttribute("value");
                    break;
                case "cssSelector":
                    elementText = webDriver.FindElementByCssSelector(elementName).GetAttribute("value");
                    break;
                case "name":
                    elementText = webDriver.FindElementByName(elementName).GetAttribute("value");
                    break;
                case "className":
                    elementText = webDriver.FindElementByClassName(elementName).GetAttribute("value");
                    break;
                case "linkText":
                    elementText = webDriver.FindElementByLinkText(elementName).GetAttribute("value");
                    break;
            }

            Thread.Sleep(timeInseconds * 1000);

            return elementText;
        }

        public static int GetNumberTextCharactersFromElement(AndroidDriver<AppiumWebElement> webDriver, string by, string elementName, int timeInseconds)
        {
            string elementText = "";
            switch (by)
            {
                case "id":
                    elementText = webDriver.FindElementById(elementName).GetAttribute("value");
                    break;
                case "xPath":
                    elementText = webDriver.FindElementByXPath(elementName).GetAttribute("value");
                    break;
                case "cssSelector":
                    elementText = webDriver.FindElementByCssSelector(elementName).GetAttribute("value");
                    break;
                case "name":
                    elementText = webDriver.FindElementByName(elementName).GetAttribute("value");
                    break;
                case "className":
                    elementText = webDriver.FindElementByClassName(elementName).GetAttribute("value");
                    break;
                case "linkText":
                    elementText = webDriver.FindElementByLinkText(elementName).GetAttribute("value");
                    break;
            }

            Thread.Sleep(timeInseconds * 1000);
            int number = elementText.Length;
            return number;
        }
    }
}
