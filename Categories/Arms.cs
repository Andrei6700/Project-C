using System;
using System.Collections.Generic;

namespace Proiect.Categories
{
    internal class Arms : Exercise
    {

        public static List<Question> ArmsQuestions()
        {
            return new List<Question>
            {
                new Question
                {
                    Text = "Care este cel mai bun exercitiu pentru antebrat",
                    Options = new List<string> { "Sam Sulek ", "Chin ups", "Hammer curls" },
                    CorrectOptionIndex = 0
                },
                new Question
                {
                    Text = "Care este cel mai bun exercitiu pentru biceps?",
                    Options = new List<string> { "Hammer curls", "Tricep dips", "Leg press" },
                    CorrectOptionIndex = 0
                },
                new Question
                {
                    Text = "Care este cel mai bun exercitiu pentru triceps?",
                    Options = new List<string> { "Bicep curls", "Tricep dips", "Leg press" },
                    CorrectOptionIndex = 1
                },
                new Question
                {
                    Text = "Care exercitiu nu este benefic pentru brate?",
                    Options = new List<string> { "Bicep curls", "Tricep dips", "Leg press" },
                    CorrectOptionIndex = 2
                },
                new Question
                {
                    Text = "Care exercitiu lucreaza cel mai mult bratele?",
                    Options = new List<string> { "Bicep curls", "Tricep dips", "Chin ups" },
                    CorrectOptionIndex = 2
               },
            };
        }

    }
}
