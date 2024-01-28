using System;
using System.Collections.Generic;

namespace Proiect.Categories
{
    internal class Back : Exercise
    {

        public static List<Question> BackQuestions()
        {
            return new List<Question>
            {
                new Question
                {
                    Text = "Care exercitiu activeaza cel mai bine marele dorsal ?",
                    Options = new List<string> { "Pull ups", "Bicep curls", "Leg press" },
                    CorrectOptionIndex = 0
                },
                new Question
                {
                    Text = "Ce exercitiu nu targeteaza trapezul ?",
                    Options = new List<string> { "Shrugs", "Deadlift", "Bicep curls" },
                    CorrectOptionIndex = 2
                },
                new Question
                {
                    Text = "Care exercitiu targeteaza muschii romboizi ?",
                    Options = new List<string> { "Rows", "Bicep curls", "Leg press" },
                    CorrectOptionIndex = 0
                },
                new Question
                {
                    Text = "Ce exercitiu nu targeteaza muschii spatelui ?",
                    Options = new List<string> { "Pull ups", "Deadlift", "Romanian Deadlift" },
                    CorrectOptionIndex = 2
                },
                new Question
                {
                    Text = "Ce exercitiu targeteaza mai multe grupe musculare a spatelui ?",
                    Options = new List<string> { "Pull ups", "Deadlift", "Rows" },
                    CorrectOptionIndex = 1
               },
            };
        }

    }
}
