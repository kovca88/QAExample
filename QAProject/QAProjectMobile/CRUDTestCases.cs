using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using QAProject.Const;
using QAProject.Models;
using System.Collections.Generic;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using Newtonsoft.Json.Linq;

namespace QAProjectMobile
{
    public class CRUDTestCases
    {
        private static AndroidDriver<AppiumWebElement> _driver;
        private static AppiumLocalService _appiumLocalService;
        List<TestCaseModel> _testCaseModels = new List<TestCaseModel>();

        [SetUp]
        public void Setup()
        {
            _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            _appiumLocalService.Start();
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "XED4C18425032290");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9.0");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.BrowserName, "Chrome");
            appiumOptions.AddAdditionalCapability(ChromeOptions.Capability, JObject.Parse("{\"w3c\":false}"));

            _driver = new AndroidDriver<AppiumWebElement>(_appiumLocalService, appiumOptions);
            if (_driver != null)
                _driver.StartActivity(Constants.APP_PACKAGE_NAME, Constants.APP_ACTIVITY_NAME);
        }

        [Test]
        public void CreateTestCases()
        {
            _testCaseModels.Add(Constants.createTestCaseModel);
            _testCaseModels.Add(Constants.readTestCaseModel);
            _testCaseModels.Add(Constants.updateTestCaseModel);
            _testCaseModels.Add(Constants.deleteAllTestCaseModel);
            _testCaseModels.Add(Constants.deleteEditedTestCaseModel);

            Methods.Methods.OpenPage(_driver, Constants.LOGIN_URL, 5);
            Methods.Methods.InputOnElement(_driver, Constants.NAME, "email", "gorankovcic88@gmail.com", 0);
            Methods.Methods.InputOnElement(_driver, Constants.NAME, "password", "kovcakis88", 0);
            Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "button.btn.btn-primary.btn-block.mt-4", 2);
            Methods.Methods.GoToPage(_driver, Constants.USE_CASE_URL);

            int i = 0;

            for (i = 0; i < _testCaseModels.Count; i++)
            {
                Methods.Methods.GoToPage(_driver, Constants.CREATE_USE_CASE_URL);
                Methods.Methods.InputOnElement(_driver, Constants.NAME, "title", _testCaseModels[i].Title, 0);
                Methods.Methods.InputOnElement(_driver, Constants.NAME, "description", _testCaseModels[i].Description, 0);
                Methods.Methods.InputOnElement(_driver, Constants.NAME, "expected_result", _testCaseModels[i].ExpectedResult, 0);
                if (_testCaseModels[i].IsAutomated)
                {
                    if (Methods.Methods.GetValueFromElement(_driver, Constants.ID, "switch", 1).Equals("false"))
                        Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "label.pt-1.ml-2", 0);
                }

                int j;

                for (j = 0; j < _testCaseModels[i].Steps.Length; j++)
                {
                    Methods.Methods.InputOnElement(_driver, Constants.NAME, "testStepId-" + j, _testCaseModels[i].Steps[j], 0);
                    Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "span.text-primary", 0);
                }

                Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "button.btn.btn-primary.mt-4.float-right", 1);
            }
            Assert.Pass();
        }

        [Test]
        public void ReadTestCases()
        {
            Methods.Methods.OpenPage(_driver, Constants.LOGIN_URL, 5);
            Methods.Methods.InputOnElement(_driver, Constants.NAME, "email", "gorankovcic88@gmail.com", 1);
            Methods.Methods.InputOnElement(_driver, Constants.NAME, "password", "kovcakis88", 1);
            Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "button.btn.btn-primary.btn-block.mt-4", 2);
            Methods.Methods.GoToPage(_driver, Constants.USE_CASE_URL);

            IList<AppiumWebElement> all = _driver.FindElements(By.CssSelector("a.list-group-item.list-group-item-action"));

            String[] allText = new String[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                allText[i++] = element.Text;
            }

            for (i = 0; i < allText.Length; i++)
            {
                string elementName = allText[i];
                Methods.Methods.ClickOnElement(_driver, Constants.LINK_TEXT, elementName, 1);
                Methods.Methods.MoveToElement(_driver, "button.btn.btn-primary.mt-4.float-right", 1);
                Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "button.btn.btn-primary.mt-4.float-right", 1);
                Thread.Sleep(2000);

            }
            Assert.Pass();
        }

        [Test]
        public void UpdateTestCases()
        {
            Methods.Methods.OpenPage(_driver, Constants.LOGIN_URL, 5);
            Methods.Methods.InputOnElement(_driver, Constants.NAME, "email", "gorankovcic88@gmail.com", 1);
            Methods.Methods.InputOnElement(_driver, Constants.NAME, "password", "kovcakis88", 1);
            Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "button.btn.btn-primary.btn-block.mt-4", 2);
            Methods.Methods.GoToPage(_driver, Constants.USE_CASE_URL);

            IList<AppiumWebElement> all = _driver.FindElements(By.CssSelector("a.list-group-item.list-group-item-action"));

            String[] allText = new String[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                allText[i++] = element.Text;
            }

            for (i = 0; i < allText.Length; i++)
            {
                string elementName = allText[i];

                Methods.Methods.ClickOnElement(_driver, Constants.LINK_TEXT, elementName, 1);

                int titleCharacters = Methods.Methods.GetNumberTextCharactersFromElement(_driver, Constants.NAME, "title", 1);
                Methods.Methods.ClearTextElement(_driver, Constants.NAME, "title", 1);
                Methods.Methods.InputOnElement(_driver, Constants.NAME, "title", String.Format(@"This field previously had {0} characters", titleCharacters), 1);
                int descriptionCharacters = Methods.Methods.GetNumberTextCharactersFromElement(_driver, Constants.NAME, "description", 1);
                Methods.Methods.ClearTextElement(_driver, Constants.NAME, "description", 1);
                Methods.Methods.InputOnElement(_driver, Constants.NAME, "description", String.Format(@"This field previously had {0} characters", descriptionCharacters), 1);
                int resultsCharacters = Methods.Methods.GetNumberTextCharactersFromElement(_driver, Constants.NAME, "expected_result", 1);
                Methods.Methods.ClearTextElement(_driver, Constants.NAME, "expected_result", 1);
                Methods.Methods.InputOnElement(_driver, Constants.NAME, "expected_result", String.Format(@"This field previously had {0} characters", resultsCharacters), 1);

                var allTextBoxes = _driver.FindElements(By.CssSelector("input#stepId.value.input-group.form-control.form-control-lg"));

                int m = 0;
                foreach (var textBox in allTextBoxes)
                {
                    int stepCharacters = Methods.Methods.GetNumberTextCharactersFromElement(_driver, Constants.NAME, "testStepId-" + m, 0);
                    Methods.Methods.ClearTextElement(_driver, Constants.NAME, "testStepId-" + m, 1);
                    Methods.Methods.InputOnElement(_driver, Constants.NAME, "testStepId-" + m, String.Format(@"This field previously had {0} characters", stepCharacters), 1);
                    m++;
                    stepCharacters = 0;
                }

                Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "button.btn.btn-primary.mt-4.float-right", 1);
                Thread.Sleep(2000);
            }
            Assert.Pass();
        }

        [Test]
        public void DeleteAllTestCases()
        {
            Methods.Methods.OpenPage(_driver, Constants.LOGIN_URL, 5);
            Methods.Methods.InputOnElement(_driver, Constants.NAME, "email", "gorankovcic88@gmail.com", 1);
            Methods.Methods.InputOnElement(_driver, Constants.NAME, "password", "kovcakis88", 1);
            Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "button.btn.btn-primary.btn-block.mt-4", 2);
            Methods.Methods.GoToPage(_driver, Constants.USE_CASE_URL);

            IList<AppiumWebElement> all = _driver.FindElements(By.CssSelector("a.list-group-item.list-group-item-action"));

            String[] allText = new String[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                allText[i++] = element.Text;
            }

            for (i = 0; i < allText.Length; i++)
            {
                string elementName = allText[i];

                Methods.Methods.ClickOnElement(_driver, Constants.LINK_TEXT, elementName, 1);
                Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "button.btn.btn-secondary.ml-2.mb-3.btn-dark.btn-lg.pull-right", 2);
                Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "button.btn.btn-lg.btn-danger", 1);
                Thread.Sleep(2000);

            }
            Assert.Pass();
        }

        [Test]
        public void DeleteAllEditedTestCases()
        {
            Methods.Methods.OpenPage(_driver, Constants.LOGIN_URL, 5);
            Methods.Methods.InputOnElement(_driver, Constants.NAME, "email", "gorankovcic88@gmail.com", 1);
            Methods.Methods.InputOnElement(_driver, Constants.NAME, "password", "kovcakis88", 1);
            Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "button.btn.btn-primary.btn-block.mt-4", 2);
            Methods.Methods.GoToPage(_driver, Constants.USE_CASE_URL);

            IList<AppiumWebElement> all = _driver.FindElements(By.CssSelector("a.list-group-item.list-group-item-action"));

            String[] allText = new String[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                allText[i++] = element.Text;
            }

            for (i = 0; i < allText.Length; i++)
            {
                string elementName = allText[i];

                if (elementName.Contains("This field previously had"))
                {
                    Methods.Methods.ClickOnElement(_driver, Constants.LINK_TEXT, elementName, 1);
                    Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "button.btn.btn-secondary.ml-2.mb-3.btn-dark.btn-lg.pull-right", 2);
                    Methods.Methods.ClickOnElement(_driver, Constants.CSS_SELECTOR, "button.btn.btn-lg.btn-danger", 1);
                }
                Thread.Sleep(2000);

            }
            Assert.Pass();
        }
    }
}