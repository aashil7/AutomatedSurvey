using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomatedSurvey.Models
{
    public class surveydata
    {
        public List<QuestionsModel> Questions { get; set; }
        public List<AnswerModel> Answers { get; set; }

        public class QuestionsModel
        {
            public string QuestionText { get; set; }
            public string QuestionComment { get; set; }

        }
        public class AnswerModel
        {
            public string AnswerText { get; set; }
            public bool IsCorrect { get; set; }
        }

    }
}