using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        private class Question
        {
            public string Text { get; set; }
            public List<string> Options { get; set; }
            public int CorrectOptionIndex { get; set; }
        }


        // intrebarile pentru brand
        private List<Question> ArmsQuestions = new List<Question>
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

        // intrebarile pentru shoulders
        private List<Question> ShouldersQuestions = new List<Question>
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

        // intrebarile pentru picioare
        private List<Question> LegsQuestions = new List<Question>
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

        // intrebarile pentru pieptan
        private List<Question> ChestQuestions = new List<Question>
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

        // intrebarile pentru spate
        private List<Question> BackQuestions = new List<Question>
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


        private List<Question> currentQuestions;
        private int currentQuestionIndex = 0;

        public Form1()
        {
            InitializeComponent();
            // Setează nivelul implicit la începător și afișează întrebările
            Arms.Checked = true;
            currentQuestions = ArmsQuestions;
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            // Verifică dacă s-au terminat întrebările pentru nivelul curent
            if (currentQuestionIndex < currentQuestions.Count)
            {
                // Afișează întrebarea și resetează label-ul pentru răspuns
                Qwestion.Text = currentQuestions[currentQuestionIndex].Text;
                answer_label.Text = "";

                // Afișează butoanele pentru opțiuni
                btn_A.Text = $" {currentQuestions[currentQuestionIndex].Options[0]}";
                btn_B.Text = $" {currentQuestions[currentQuestionIndex].Options[1]}";
                btn_C.Text = $" {currentQuestions[currentQuestionIndex].Options[2]}";
            }
            else
            {
                // Dacă s-au terminat întrebările, afișează un mesaj și resetează la prima întrebare
                MessageBox.Show("Ai terminat întrebările pentru acest nivel!");
                currentQuestionIndex = 0;
                DisplayQuestion();
            }
        }

        // Evenimente pentru butoane și radio buttons
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Qwestion_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            // incrementare indexului pt urmatoarea intrebare
            currentQuestionIndex++;
            DisplayQuestion();
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            // verifica daca raspunsul e corect
            if (currentQuestions[currentQuestionIndex].CorrectOptionIndex == 0)
            {
                // raspuns corect
                answer_label.ForeColor = Color.Green; 
                answer_label.Text = "Răspunsul corect!";
            }
            else
            {
                //rapsun gresit
                answer_label.ForeColor = Color.Red; 
                answer_label.Text = "Mai încearcă!";
            }
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            // verifica daca raspunsul este corect
            if (currentQuestions[currentQuestionIndex].CorrectOptionIndex == 1)
            {
                answer_label.ForeColor = Color.Green; 
                answer_label.Text = "Răspunsul corect!";
            }
            else
            {
                answer_label.ForeColor = Color.Red; 
                answer_label.Text = "Mai încearcă!";
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            // verifica daca raspunsul este corect
            if (currentQuestions[currentQuestionIndex].CorrectOptionIndex == 2)
            {
                answer_label.ForeColor = Color.Green; 
                answer_label.Text = "Răspunsul corect!";
            }
            else
            {
                answer_label.ForeColor = Color.Red; 
                answer_label.Text = "Mai încearcă!";
            }
        }

        private void Arms_CheckedChanged(object sender, EventArgs e)
        {
            if (Arms.Checked)
            {
                currentQuestions = ArmsQuestions;
                currentQuestionIndex = 0;
                DisplayQuestion();
            }

        }

        private void Shoulders_CheckedChanged(object sender, EventArgs e)
        {
            if (Shoulders.Checked)
            {
                currentQuestions = ShouldersQuestions;
                currentQuestionIndex = 0;
                DisplayQuestion();
            }
        }

        private void Legs_CheckedChanged(object sender, EventArgs e)
        {
            if (Legs.Checked)
            {
                currentQuestions = LegsQuestions;
                currentQuestionIndex = 0;
                DisplayQuestion();
            }
        }

        //lvl back
        private void Back_CheckedChanged(object sender, EventArgs e)
        {
            if (Back.Checked)
            {
                currentQuestions = BackQuestions;
                currentQuestionIndex = 0;
                DisplayQuestion();
            }
        }
        //lvl chest
        private void Chest_CheckedChanged(object sender, EventArgs e)
        {
            if (Chest.Checked)
            {
                currentQuestions = ChestQuestions;
                currentQuestionIndex = 0;
                DisplayQuestion();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // e titlul
        }

        //picture box 1
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //picture box 2
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
