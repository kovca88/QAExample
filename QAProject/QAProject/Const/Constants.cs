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

        public static string[] CreateTestCaseSteps = { "User enter mail <gorankovcic88@gmail.com>", "User enter password <kovcakis88>", "Page 'Dashboard' is open", "User click on card 'Use Cases'", "Page 'Use cases' is open", "User click on button 'Create Use Case'", "User enter title <Create test case>", "User enter in description <Creating a test case>", "Expected result <User successfully create test case>", "User check 'Automatic'", "User press on button 'Submit'", "User successfully create a test case"};
        public static string[] ReadTestCaseSteps = { "User enter mail <gorankovcic88@gmail.com>", "User enter password <kovcakis88>", "Page 'Dashboard' is open", "User click on card 'Use Cases'", "Page 'Use cases' is open", "User successfully read a test case" };
        public static string[] UpdateTestCaseSteps = { "User enter mail <gorankovcic88@gmail.com>", "User enter password <kovcakis88>", "Page 'Dashboard' is open", "User click on card 'Use Cases'", "Page 'Use cases' is open", "User click on button 'Create Use Case'", "User enter title <Create test case>", "User enter in description <Creating a test case>", "Expected result <User successfully create test case>", "User check 'Automatic'", "User press on button 'Submit'", "User successfully edit a test case" };
        public static string[] DeleteTestCaseSteps = { "User enter mail <gorankovcic88@gmail.com>", "User enter password <kovcakis88>", "Page 'Dashboard' is open", "User click on card 'Use Cases'", "User click on trash icon", "User click on button 'Delete' on pop up", "User successfully delete a test case" };
        public static string[] EmptyFieldsTestCaseSteps = { "User enter mail <gorankovcic88@gmail.com>", "User enter password <kovcakis88>", "Page 'Dashboard' is open", "User click on card 'Use Cases'", "Page 'Use cases' is open", "User click on button 'Create Use Case'", "User press on button 'Submit'", "User get message that the fields are required" };

        public static TestCaseModel createTestCaseModel = new TestCaseModel("Create test case", "Creating a new test case", "Test case successfully created",true, CreateTestCaseSteps);
        public static TestCaseModel readTestCaseModel = new TestCaseModel("Read test case", "Read test case from list", "Reading test case is successfully", true, ReadTestCaseSteps);
        public static TestCaseModel updateTestCaseModel = new TestCaseModel("Update test case", "Edit test case from list", "Test case successfully edited", true, UpdateTestCaseSteps);
        public static TestCaseModel deleteTestCaseModel = new TestCaseModel("Delete test case", "Delete test case from list", "Test case successfully deleted", true, DeleteTestCaseSteps);
        public static TestCaseModel emptyFieldsTestCaseModel = new TestCaseModel("Empty fields test case", "Show message that fields are required", "Message are displayed", true, EmptyFieldsTestCaseSteps);

        public static string APP_PACKAGE_NAME = "com.android.chrome";
        public static string APP_ACTIVITY_NAME = "com.google.android.apps.chrome.Main";

        public static string ID = "id";
        public static string NAME = "name";
        public static string CSS_NAME = "cssName";
        public static string CSS_SELECTOR = "cssSelector";
        public static string LINK_TEXT = "linkText";

    }
}