using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace QAProject.Configuration
{
    public static class Driver
    {
        private static IWebDriver _browser;

        public static IWebDriver Browser
        {
            get
            {
                if (_browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return _browser;
            }
            private set => _browser = value;
        }

        public static void StartBrowser(int defaultTimeOut = 30)
        {
            var timeOutTime = TimeSpan.FromMinutes(5);
            Browser = new ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);
        }

        public static void StopBrowser()
        {
            Thread.Sleep(2000);
            Browser.Manage().Cookies.DeleteAllCookies();
            Browser.Quit();
            Browser.Dispose();
            Browser = null;
        }
    }
}
