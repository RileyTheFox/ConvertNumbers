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
        private List<Question> Questions = new();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateNewQuestions()
        {
            Questions.AddRange(new Question[]
            {
                new(q1Label, q1Text, q1Answer, q1Check),
                new(q2Label, q2Text, q2Answer, q2Check),
                new(q3Label, q3Text, q3Answer, q3Check),
                new(q4Label, q4Text, q4Answer, q4Check),
                new(q5Label, q5Text, q5Answer, q5Check),
                new(q6Label, q6Text, q6Answer, q6Check),
                new(q7Label, q7Text, q7Answer, q7Check),
                new(q8Label, q8Text, q8Answer, q8Check)
            });
        }
    }
}