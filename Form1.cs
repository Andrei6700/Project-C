using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Proiect.Categories;

namespace Proiect
{
    public class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int CorrectOptionIndex { get; set; }
    }

    public partial class Form1 : Form
    {
        private List<Question> currentQuestions;
        private int currentQuestionIndex = 0;
        private FisierText fisierText;  
        private string currentResponse;

        //constructorul 
        public Form1()
        {
            InitializeComponent();
            Arms.Checked = true; // defaul bratele
            SetCategory(Proiect.Categories.Arms.ArmsQuestions()); // defaul bratele
            fisierText = new FisierText("C:\\Users\\andre\\OneDrive\\Desktop\\fisier.txt"); 
            DisplayQuestion();
        }

        private void SetCategory(List<Question> questions)
        {
            currentQuestions = questions;
            currentQuestionIndex = 0;
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < currentQuestions.Count)
            {
                Qwestion.Text = currentQuestions[currentQuestionIndex].Text;
                answer_label.Text = "";
                btn_A.Text = $" {currentQuestions[currentQuestionIndex].Options[0]}";
                btn_B.Text = $" {currentQuestions[currentQuestionIndex].Options[1]}";
                btn_C.Text = $" {currentQuestions[currentQuestionIndex].Options[2]}";
            }
            else
            {
                MessageBox.Show("Ai terminat întrebările pentru acest nivel!");
                fisierText.AppendResponse(currentResponse);  
                currentQuestionIndex = 0;
                DisplayQuestion();
            }
        }

        // radiobuttons : iar daca alegem o categorie din acele radiobuttons , se va schimba categoria respectiva
        private void Category_CheckedChanged(object sender, EventArgs e, List<Question> categoryQuestions)
        {
            if ((sender as RadioButton)?.Checked == true)
            {
                SetCategory(categoryQuestions);
                DisplayQuestion();
            }
        }

        //btn next
        private void btn_Next_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            DisplayQuestion();
        }

        //btn varianta a
        private void btn_A_Click(object sender, EventArgs e)
        {
            ProcessAnswer(0);
        }

        //bnt vairanta b
        private void btn_B_Click(object sender, EventArgs e)
        {
            ProcessAnswer(1);
        }

        //btn varianta c
        private void btn_C_Click(object sender, EventArgs e)
        {
            ProcessAnswer(2);
        }

        private void ProcessAnswer(int selectedOptionIndex)
        {
            if (currentQuestions[currentQuestionIndex].CorrectOptionIndex == selectedOptionIndex)
            {
                answer_label.ForeColor = Color.Green;
                answer_label.Text = "Răspunsul corect!";
                currentResponse = "Răspunsul corect!" + Environment.NewLine;  // actualizam currentResponse
            }
            else
            {
                answer_label.ForeColor = Color.Red;
                answer_label.Text = "Mai incearca!";
                currentResponse = "Mai incearca!" + Environment.NewLine;  // actualizam currentResponse
            }
            fisierText.AppendResponse(currentResponse);  // adauga raspunsul in fisier
        }

        //checkboxes
        //chexboxuul de la brate
        private void Arms_CheckedChanged(object sender, EventArgs e)
        {
            SetCategory(Proiect.Categories.Arms.ArmsQuestions());
            DisplayQuestion();
        }

        //chexboxuul de la umeri
        private void Shoulders_CheckedChanged(object sender, EventArgs e)
        {
            SetCategory(Proiect.Categories.Shoulders.ShouldersQuestions());
            DisplayQuestion();
        }

        //chexboxuul de la picioare
        private void Legs_CheckedChanged(object sender, EventArgs e)
        {
            SetCategory(Proiect.Categories.Legs.LegsQuestions());
            DisplayQuestion();
        }

        //chexboxuul de la spate
        private void Back_CheckedChanged(object sender, EventArgs e)
        {
            SetCategory(Proiect.Categories.Back.BackQuestions());
            DisplayQuestion();
        }

        //chexboxuul de la piept
        private void Chest_CheckedChanged(object sender, EventArgs e)
        {
            SetCategory(Proiect.Categories.Chest.ChestQuestions());
            DisplayQuestion();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //picture box, nu sterg ca nu mai vad desigerul
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          //picture box, nu sterg ca nu mai vad desigerul
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // e titlul
        }

    }
}
