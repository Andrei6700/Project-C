using System.Collections.Generic;
using System;
using System.Linq;

public enum Level
{
    Beginner,
    Intermediate,
    Advanced
}

public class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public int CorrectOption { get; set; }
    public Level Level { get; set; }
}

public class BeginnerQuestion : Question
{
    public BeginnerQuestion()
    {
        Level = Level.Beginner;
    }
}

public class IntermediateQuestion : Question
{
    public IntermediateQuestion()
    {
        Level = Level.Intermediate;
    }
}

public class AdvancedQuestion : Question
{
    public AdvancedQuestion()
    {
        Level = Level.Advanced;
    }
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

    public IEnumerable<Question> GetQuestionsByLevel(Level level)
    {
        return questions.Where(q => q.Level == level);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Quiz quiz = new Quiz();

        try
        {
            quiz.AddQuestion(new BeginnerQuestion { Text = "1+1", Options = new List<string> { "1", "2", "3" }, CorrectOption = 2 });
            quiz.AddQuestion(new IntermediateQuestion { Text = "2*2", Options = new List<string> { "2", "4", "3" }, CorrectOption = 2 });
            quiz.AddQuestion(new AdvancedQuestion { Text = "5*5", Options = new List<string> { "10", "2", "25" }, CorrectOption = 3 });

            Console.WriteLine("Alegeți un nivel: a) Începător, b) Mediu, c) Avansat");
            char userLevel = Convert.ToChar(Console.ReadLine().ToLower());

            Level level = Level.Beginner;
            switch (userLevel)
            {
                case 'a':
                    level = Level.Beginner;
                    break;
                case 'b':
                    level = Level.Intermediate;
                    break;
                case 'c':
                    level = Level.Advanced;
                    break;
                default:
                    Console.WriteLine("Opțiune invalidă.");
                    return;
            }

            var questions = quiz.GetQuestionsByLevel(level);

            int correctAnswers = 0;

            foreach (var question in questions)
            {
                Console.WriteLine(question.Text);
                for (int i = 0; i < question.Options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Options[i]}");
                }

                Console.Write("Alegeti o optiune:");
                int userOption = Convert.ToInt32(Console.ReadLine());

                if (userOption - 1 == question.CorrectOption - 1)
                {
                    Console.WriteLine("Corect!");
                    correctAnswers++;
                }
                else
                {
                    Console.WriteLine("Incorect!");
                    Console.WriteLine($"Raspusnul corest corect era: {question.Options[question.CorrectOption - 1]}");
                }
            }

            Console.WriteLine($"A-ti raspusn corect la {correctAnswers} intrebari");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"A aparut o eroare: {ex.Message}");
        }
        Console.WriteLine("....");
        Console.ReadLine(); 
    }
}
