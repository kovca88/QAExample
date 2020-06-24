using System;
using System.Collections.Generic;
using System.Text;

namespace QAProject.Models
{
    public class TestCaseModel
    {
        public TestCaseModel(string title, string description, string expectedResult, bool isAutomated, string[] steps)
        {
            Title = title;
            Description = description;
            ExpectedResult = expectedResult;
            IsAutomated = isAutomated;
            Steps = steps;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string ExpectedResult { get; set; }
        public bool IsAutomated { get; set; }
        public string[] Steps { get; set; }
    }
}