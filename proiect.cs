using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public int CorrectOption { get; set; }
}

public class Quiz
{
    private List<Question> questions;

    public Quiz()
    {
        questions = new List<Question>();
    }

    public void AddQuestion(Question question)
    {
        questions.Add(question);
    }

    public IEnumerable<Question> GetAllQuestions()
    {
        return questions;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Quiz quiz = new Quiz();

        try
        {
            quiz.AddQuestion(new Question { Text = "1+1", Options = new List<string> { "1", "2", "3" }, CorrectOption = 2 });

            var questions = quiz.GetAllQuestions();

            int correctAnswers = 0;

            foreach (var question in questions)
            {
                bool correct = false;
                while (!correct)
                {
                    Console.WriteLine(question.Text);
                    for (int i = 0; i < question.Options.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {question.Options[i]}");
                    }

                    Console.Write("Alege o optiune: ");
                    int userOption = Convert.ToInt32(Console.ReadLine());

                    if (userOption == question.CorrectOption)
                    {
                        Console.WriteLine("Corect! ");
                        correctAnswers++;
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Gresit Vericule !!!");
                        Console.WriteLine($"raspunsul corest este: {question.Options[question.CorrectOption - 1]}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("eroare " + ex.Message);
        }
    }
}