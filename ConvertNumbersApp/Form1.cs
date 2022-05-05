using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConvertNumbersApp
{
    public partial class Form1 : Form
    {

        private List<Question> Questions = new();
        
        public Form1()
        {
            InitializeComponent();

            // Automatically generate the questions on initialization
            GenerateNewQuestions();


        }

        private void GenerateNewQuestions()
        {
            // Clear existing questions
            Questions.Clear();

            var random = new Random();

            // Add the 6 types of questions
            Questions.Add(new Question(q1Label, q1Text, q1Answer, q1Check, correctAnswer1, ref random, QuestionFlag.DenaryToBinary));
            Questions.Add(new Question(q2Label, q2Text, q2Answer, q2Check, correctAnswer2, ref random, QuestionFlag.BinaryToDenary));
            Questions.Add(new Question(q3Label, q3Text, q3Answer, q3Check, correctAnswer3, ref random, QuestionFlag.BinaryToHex));
            Questions.Add(new Question(q4Label, q4Text, q4Answer, q4Check, correctAnswer4, ref random, QuestionFlag.HexToBinary));
            Questions.Add(new Question(q5Label, q5Text, q5Answer, q5Check, correctAnswer5, ref random, QuestionFlag.DenaryToHex));
            Questions.Add(new Question(q6Label, q6Text, q6Answer, q6Check, correctAnswer6, ref random, QuestionFlag.HexToDenary));
        }

        // Called when the Generate New button is clicked
        private void generateNewButton_Click(object sender, EventArgs e)
        {
            GenerateNewQuestions();
        }

        // Called when the Submit button is clicked
        private void submitButton_Click(object sender, EventArgs e)
        {
            foreach(Question question in Questions)
            {
                question.MarkQuestion();
            }
        }
    }
}