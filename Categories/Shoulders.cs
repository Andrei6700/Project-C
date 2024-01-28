using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Categories
{
    internal class Shoulders : Exercise
    {
        public static List<Question> ShouldersQuestions()
        {
            return new List<Question>
            {
                new Question        
                {
                    Text = "Care este cel mai bun exercitiu pentru deltoidul posterior ?",
                    Options = new List<string> { "Face Pull", "Military Press", "Lateral Raises" },
                    CorrectOptionIndex = 0
                },
                new Question
                {
                    Text = "Cel mai prost exercitiu pentru umeri ?",
                    Options = new List<string> { "Upright Rows", "Military Press", "Lateral Raises" },
                    CorrectOptionIndex = 0
                },
                new Question
                {
                    Text = "Ce unghi trebuie sa aibe bratele cand faci militari press ?",
                    Options = new List<string> { "90 grade", "45 grade", "30 grade" },
                    CorrectOptionIndex = 0
                },
                new Question
                {
                    Text = "Care exercitiu targeteaza deltoidul medial ?",
                    Options = new List<string> { "Lateral Raises", "Military Press", "Upright Rows" },
                    CorrectOptionIndex = 0
                },
                new Question
                {
                    Text = "Care exercitiu nu targeteaza deltoidul frontal",
                    Options = new List<string> { "Rear Delt Flyes", "Military Press", "Front Raises" },
                    CorrectOptionIndex = 0
               },
            };
        }

    }
}
