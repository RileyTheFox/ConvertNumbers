using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertNumbersApp
{
    public partial class Form1 : Form
    {
        public const string CHECKMARK = "🗸";
        public const string RED_CROSS = "✘";

        public static readonly Color GREEN_COLOR = Color.FromArgb(0, 128, 0);
        public static readonly Color RED_COLOR = Color.FromArgb(220, 20, 60);

        private List<Question> Questions = new();
        
        public Form1()
        {
            InitializeComponent();

            GenerateNewQuestions();
        }

        private void GenerateNewQuestions()
        {
            Questions.Clear();

            var random = new Random();

            Questions.Add(new Question(q1Label, q1Text, q1Answer, q1Check, ref random, QuestionFlag.DenaryToBinary));
            Questions.Add(new Question(q2Label, q2Text, q2Answer, q2Check, ref random, QuestionFlag.BinaryToDenary));
            Questions.Add(new Question(q3Label, q3Text, q3Answer, q3Check, ref random, QuestionFlag.BinaryToHex));
            Questions.Add(new Question(q4Label, q4Text, q4Answer, q4Check, ref random, QuestionFlag.HexToBinary));
            Questions.Add(new Question(q5Label, q5Text, q6Answer, q5Check, ref random, QuestionFlag.DenaryToHex));
            Questions.Add(new Question(q6Label, q6Text, q4Answer, q6Check, ref random, QuestionFlag.HexToDenary));
        }

        private void generateNewButton_Click(object sender, EventArgs e)
        {
            GenerateNewQuestions();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            foreach(Question question in Questions)
            {
                question.MarkQuestion();
            }
        }
    }
}