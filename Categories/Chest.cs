using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Categories
{
    internal class Chest : Exercise
    {

        // intrebarile pentru picioare
        public static List<Question> ChestQuestions()
        {
            return new List<Question>
            {
               new Question
    {
        Text = "Ce exercitiu este bun pentru forta la piept?",
        Options = new List<string> { "Bench Press", "Bicep Curls", "Leg Press" },
        CorrectOptionIndex = 0
    },
    new Question
    {
        Text = "Care exercitiu lucreaza partea superioara a pieptului?",
        Options = new List<string> { "Bicep Curls", "Incline Bench Press", "Leg Press" },
        CorrectOptionIndex = 1
    },
    new Question
    {
        Text = "Care exercitiu nu este benefic pentru piept?",
        Options = new List<string> { "Bench Press", "Bicep Curls", "Leg Press" },
        CorrectOptionIndex = 0
    },
    new Question
    {
        Text = "Care exercitiu lucreaza partea inferioara a pieptului?",
        Options = new List<string> { "Bicep Curls", "Leg Press", "Decline Bench Press" },
        CorrectOptionIndex = 2
    },
    new Question
    {
        Text = "Care exercitiu lucreaza intregul piept?",
        Options = new List<string> { "Bicep Curls", "Dumbbell Press", "Leg Press" },
        CorrectOptionIndex = 1
               },
            };
        }

    }
}
