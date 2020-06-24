using QAProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QAProject.Const
{
    public class Constants
    {
        public static string URL = "https://qa-sandbox.apps.htec.rs/";
        public static string LOGIN_URL = "https://qa-sandbox.apps.htec.rs/login";
        public static string USE_CASE_URL = "https://qa-sandbox.apps.htec.rs/use-cases";
        public static string CREATE_USE_CASE_URL = "https://qa-sandbox.apps.htec.rs/create-usecase";

        public static string[] CreateTestCaseSteps = { "User open page 'https://qa-sandbox.apps.htec.rs/login'", "User enter mail <gorankovcic88@gmail.com>", "User enter password <kovcakis88>", "Page 'Dashboard' is open", "User click on card 'Use Cases'", "Page 'Use cases' is open", "User click on button 'Create Use Case'", "User enter title <Create test case>", "User enter in description <Creating a new test case>", "Expected result <Test case successfully created>", "User check 'Automatic'", "User enter step 'User enter mail <gorankovcic88@gmail.com>'", "User enter step 'User enter password <kovcakis88>'", "User enter step 'Page 'Dashboard' is open", "User enter step 'User click on card 'Use Cases''", "User enter step 'User click on button 'Create Use case''", "User enter step 'User enter title <Create test case>'", "User enter step 'User enter in description <Creating a new test case>'", "User enter step 'Expected result <Test case successfully created>'", "User enter step 'User check 'Automatic''", "User enter step 'User click on button 'Submit''", "User enter step 'User successfully create a test case'", "User click on button 'Submit'", "User successfully create a test case" };
        public static string[] ReadTestCaseSteps = { "User open page 'https://qa-sandbox.apps.htec.rs/login'", "User enter mail <gorankovcic88@gmail.com>", "User enter password <kovcakis88>", "Page 'Dashboard' is open", "User click on card 'Use Cases'", "Page 'Use cases' is open", "User click on item 'Delete test cases'", "User click on button 'Submit'", "User successfully read a test case" };
        public static string[] UpdateTestCaseSteps = { "User open page 'https://qa-sandbox.apps.htec.rs/login'", "User enter mail <gorankovcic88@gmail.com>", "User enter password <kovcakis88>", "Page 'Dashboard' is open", "User click on card 'Use Cases'", "Page 'Use cases' is open", "User click on item 'Read test cases'", "User enter in title <This field previously had 14 characters>", "User enter in description <This field previously had 24 characters>", "User enter in expected results <This field previously had 33 characters>", "User check 'Automatic'", "User press on button 'Submit'", "User successfully edit a test case" };
        public static string[] DeleteTestCaseSteps = { "User open page 'https://qa-sandbox.apps.htec.rs/login'", "User enter mail <gorankovcic88@gmail.com>", "User enter password <kovcakis88>", "Page 'Dashboard' is open", "User click on card 'Use Cases'", "User click on item 'Delete all test cases'", "User click on bin icon", "User click on button 'Delete' on pop up", "User successfully delete a test case" };
        public static string[] UpdateAllTestCaseSteps = { "User open page 'https://qa-sandbox.apps.htec.rs/login'", "User enter mail <gorankovcic88@gmail.com>", "User enter password <kovcakis88>", "Page 'Dashboard' is open", "User click on card 'Use Cases'", "Page 'Use cases' is open", "User click on all items which contain ''This field previously had''", "Test case is open", "User click on bin icon", "User click on button 'Delete' on pop up", "User successfully delete a test case" };

        public static TestCaseModel createTestCaseModel = new TestCaseModel("Create test case", "Creating a new test case", "Test case successfully created",true, CreateTestCaseSteps);
        public static TestCaseModel readTestCaseModel = new TestCaseModel("Read test case", "Read test case from list", "Reading test case is successfully", true, ReadTestCaseSteps);
        public static TestCaseModel updateTestCaseModel = new TestCaseModel("Update test case", "Edit test case from list", "Test case successfully edited", true, UpdateTestCaseSteps);
        public static TestCaseModel deleteAllTestCaseModel = new TestCaseModel("Delete all test cases", "Delete test case from list", "Test case successfully deleted", true, DeleteTestCaseSteps);
        public static TestCaseModel deleteEditedTestCaseModel = new TestCaseModel("Delete all edited test cases", "Delete all edited test cases which title contain 'This field previously had' ", "Edited test cases deleted", true, UpdateAllTestCaseSteps);

        public static string APP_PACKAGE_NAME = "com.android.chrome";
        public static string APP_ACTIVITY_NAME = "com.google.android.apps.chrome.Main";

        public static string ID = "id";
        public static string NAME = "name";
        public static string CSS_NAME = "cssName";
        public static string CSS_SELECTOR = "cssSelector";
        public static string LINK_TEXT = "linkText";

    }
}