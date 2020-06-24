using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Threading;

namespace QAProject.Configuration
{
    [TestFixture]
    public class BrowserConfig
    {
        [OneTimeSetUp]
        public static void Init()
        {
            Driver.StartBrowser();
        }

        [OneTimeTearDown]
        public static void AfterTest()
        {
            Driver.StopBrowser();
        }
    }
}