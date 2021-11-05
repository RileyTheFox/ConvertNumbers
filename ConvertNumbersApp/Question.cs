using System;
using System.Linq;
using System.Windows.Forms;

namespace ConvertNumbersApp
{
    public class Question
    {
        private const string CHECKMARK = "🗸";
        private const string RED_CROSS = "✘";
        
        public Label Label;
        public TextBox QuestionText;
        public TextBox UserAnswer;
        public Label Checkmark;

        private QuestionFlag QuestionType;
        private string Answer;
        
        public Question(Label label, TextBox text, TextBox userAnswer, Label checkmark, ref Random random, QuestionFlag type = QuestionFlag.Default)
        {
            Label = label;
            QuestionText = text;
            UserAnswer = userAnswer;
            Checkmark = checkmark;
            QuestionType = type;

            UserAnswer.Text = "";
            Checkmark.Visible = false;

            if(type == QuestionFlag.Default)
                QuestionType = (QuestionFlag)random.Next(0, 6);

            int denary = random.Next(256);

            switch (type)
            {
                case QuestionFlag.DenaryToBinary:
                    Label.Text = "Denary -> Binary";
                    QuestionText.Text = denary.ToString();
                    Answer = Converters.DenaryToBinary(denary);
                    break;
                case QuestionFlag.BinaryToDenary:
                    Label.Text = "Binary -> Denary";
                    QuestionText.Text = Converters.DenaryToBinary(denary);
                    Answer = denary.ToString();
                    break;
                case QuestionFlag.BinaryToHex:
                    Label.Text = "Binary -> Hex";
                    QuestionText.Text = Converters.DenaryToBinary(denary);
                    Answer = Converters.DenaryToHex(denary);
                    break;
                case QuestionFlag.HexToBinary:
                    Label.Text = "Hex -> Binary";
                    QuestionText.Text = Converters.DenaryToHex(denary);
                    Answer = Converters.DenaryToBinary(denary);
                    break;
                case QuestionFlag.DenaryToHex:
                    Label.Text = "Denary -> Hex";
                    QuestionText.Text = denary.ToString();
                    Answer = Converters.DenaryToHex(denary);
                    break;
                case QuestionFlag.HexToDenary:
                    Label.Text = "Hex -> Denary";
                    QuestionText.Text = Converters.DenaryToHex(denary);
                    Answer = denary.ToString();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void MarkQuestion()
        {
            if (ValidateAnswer())
            {
                Checkmark.Text = Form1.CHECKMARK;
                Checkmark.ForeColor = Form1.GREEN_COLOR;
                Checkmark.Visible = true;
            }
            else
            {
                Checkmark.Text = Form1.RED_CROSS + $" {Answer}";
                Checkmark.ForeColor = Form1.RED_COLOR;
                Checkmark.Visible = true;
            }
        }

        public bool ValidateAnswer()
        {
            bool correct = false;

            switch (QuestionType)
            {
                case QuestionFlag.DenaryToBinary:
                    // TODO Implement regex pattern for infinite leading zeros
                    if (UserAnswer.Text == Answer)
                        correct = true;
                    break;
                case QuestionFlag.BinaryToDenary:
                case QuestionFlag.BinaryToHex:
                    if (UserAnswer.Text == Answer)
                        correct = true;
                    break;
                case QuestionFlag.HexToBinary:
                    // TODO Regex pattern leading zeros
                    break;
                case QuestionFlag.DenaryToHex:
                case QuestionFlag.HexToDenary:
                    if (UserAnswer.Text == Answer)
                        correct = true;
                    break;
            }

            return correct;
        }
    }

    public enum QuestionFlag
    {
        Default = -1,
        DenaryToBinary = 0,
        BinaryToDenary = 1,
        BinaryToHex = 2,
        HexToBinary = 3,
        DenaryToHex = 4,
        HexToDenary = 5
    }

    // TODO
    // Not random
    // 6 questions, 1 of each
}