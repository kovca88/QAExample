using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace QAProject.Methods
{
    public class Methods
    {

        public static void StartBrowser(IWebDriver driver, string url)
        {
            driver = new ChromeDriver();
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);
        }

        public static void OpenPage(IWebDriver driver, string url)
        {
            driver = new ChromeDriver();
            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);
            Thread.Sleep(2000);
        }

        public static void GoToPage(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(2000);
        }

        public static void ClickOnElement(IWebDriver webDriver, string by, string elementName, int timeInseconds)
        {
            switch (by)
            {
                case "id":
                    webDriver.FindElement(By.Id(elementName)).Click();
                    break;
                case "xPath":
                    webDriver.FindElement(By.XPath(elementName)).Click();
                    break;
                case "cssSelector":
                    webDriver.FindElement(By.CssSelector(elementName)).Click();
                    break;
                case "name":
                    webDriver.FindElement(By.Name(elementName)).Click();
                    break;
                case "className":
                    webDriver.FindElement(By.ClassName(elementName)).Click();
                    break;
                case "linkText":
                    webDriver.FindElement(By.LinkText(elementName)).Click();
                    break;
            }

            Thread.Sleep(timeInseconds*1000);
        }

        public static void InputOnElement(IWebDriver webDriver, string by, string elementName, string inputText, int timeInSeconds)
        {
            switch (by)
            {
                case "id":
                    webDriver.FindElement(By.Id(elementName)).SendKeys(inputText);
                    break;
                case "xPath":
                    webDriver.FindElement(By.XPath(elementName)).SendKeys(inputText);
                    break;
                case "cssSelector":
                    webDriver.FindElement(By.CssSelector(elementName)).SendKeys(inputText);
                    break;
                case "name":
                    webDriver.FindElement(By.Name(elementName)).SendKeys(inputText);
                    break;
                case "className":
                    webDriver.FindElement(By.ClassName(elementName)).SendKeys(inputText);
                    break;
            }

            Thread.Sleep(timeInSeconds * 1000);
        }              

        public static void ClearTextElement(IWebDriver webDriver, string by, string elementName, int timeInSeconds)
        {
            switch (by)
            {
                case "id":
                    webDriver.FindElement(By.Id(elementName)).Clear();
                    break;
                case "xPath":
                    webDriver.FindElement(By.XPath(elementName)).Clear();
                    break;
                case "cssSelector":
                    webDriver.FindElement(By.CssSelector(elementName)).Clear();
                    break;
                case "name":
                    webDriver.FindElement(By.Name(elementName)).Clear();
                    break;
                case "className":
                    webDriver.FindElement(By.ClassName(elementName)).Clear();
                    break;
            }

            Thread.Sleep(timeInSeconds * 1000);
        }

        public static string GetValueFromElement(IWebDriver webDriver, string by, string elementName, int timeInseconds)
        {
            string elementText = "";
            switch (by)
            {
                case "id":
                    elementText = webDriver.FindElement(By.Id(elementName)).GetAttribute("value");
                    break;
                case "xPath":
                    elementText = webDriver.FindElement(By.XPath(elementName)).GetAttribute("value");
                    break;
                case "cssSelector":
                    elementText = webDriver.FindElement(By.CssSelector(elementName)).GetAttribute("value");
                    break;
                case "name":
                    elementText = webDriver.FindElement(By.Name(elementName)).GetAttribute("value");
                    break;
                case "className":
                    elementText = webDriver.FindElement(By.ClassName(elementName)).GetAttribute("value");
                    break;
                case "linkText":
                    elementText = webDriver.FindElement(By.LinkText(elementName)).GetAttribute("value");
                    break;
            }
                        
            Thread.Sleep(timeInseconds * 1000);

            return elementText;
        }

        public static int GetNumberTextCharactersFromElement(IWebDriver webDriver, string by, string elementName, int timeInseconds)
        {
            string elementText = "";
            switch (by)
            {
                case "id":
                    elementText = webDriver.FindElement(By.Id(elementName)).GetAttribute("value");
                    break;
                case "xPath":
                    elementText = webDriver.FindElement(By.XPath(elementName)).GetAttribute("value");
                    break;
                case "cssSelector":
                    elementText = webDriver.FindElement(By.CssSelector(elementName)).GetAttribute("value");
                    break;
                case "name":
                    elementText = webDriver.FindElement(By.Name(elementName)).GetAttribute("value");
                    break;
                case "className":
                    elementText = webDriver.FindElement(By.ClassName(elementName)).GetAttribute("value");
                    break;
                case "linkText":
                    elementText = webDriver.FindElement(By.LinkText(elementName)).GetAttribute("value");
                    break;
            }

            Thread.Sleep(timeInseconds * 1000);
            int number = elementText.Length;
            return number;
        }
    }
}