using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Categories
{
    internal class Legs : Exercise
    {

        // intrebarile pentru picioare
        public static List<Question> LegsQuestions()
        {
            return new List<Question>
            {
                new Question
                {
                    Text = "Cel mai bun exercitiu pentru Cvadriceps ?",
                    Options = new List<string> { "Front Squats", "Hammer curls", "Leg press" },
                    CorrectOptionIndex = 0
                },
                new Question        
                {
                    Text = "Cel mai bun exercitiu pentru gambe",
                    Options = new List<string> { "Ridicari pe varfuri", "leg press", "Ridicari pe varfuri din sezut ?" },
                    CorrectOptionIndex = 0
                },
                new Question
                {
                    Text = "Cel mai prost exercitiu pentru bicepsul femural ?",
                    Options = new List<string> { "Leg extensions", "Deadlifts", "Lunges" },
                    CorrectOptionIndex = 0
                },
                new Question
                {
                    Text = "Care exercitiu nu lucreaza cvadricepsul?",
                    Options = new List<string> { "Leg curls", "Squats", "Leg press" },
                    CorrectOptionIndex = 0
                },
                new Question
                {
                    Text = "Care exercitiu lucreaza cel mai mult fesierii?",
                    Options = new List<string> { "Hip thrusts", "Squats", "Leg press" },
                    CorrectOptionIndex = 0
                },
            };
        }
     
    }
}
