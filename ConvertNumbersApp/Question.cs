using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConvertNumbersApp
{
    public class Question
    {
        private const string CHECKMARK = "🗸";
        private const string RED_CROSS = "❌";

        private readonly Color GREEN_COLOR = Color.FromArgb(0, 128, 0);
        private readonly Color RED_COLOR = Color.FromArgb(220, 20, 60);

        private readonly Font CHECKMARK_FONT = new("Microsoft Sans Serif", 16f, FontStyle.Regular);
        private readonly Font CROSS_FONT = new("Microsoft Sans Serif", 7, FontStyle.Regular);

        public Label Label;
        public TextBox QuestionText;
        public TextBox UserAnswer;
        public Label Checkmark;
        public Label AnswerLabel;

        private readonly QuestionFlag QuestionType;
        private readonly string Answer;
        
        public Question(Label label, TextBox text, TextBox userAnswer, Label checkmark, Label answerLabel, ref Random random, QuestionFlag type = QuestionFlag.Default)
        {
            Label = label;
            QuestionText = text;
            UserAnswer = userAnswer;
            Checkmark = checkmark;
            AnswerLabel = answerLabel;
            QuestionType = type;

            UserAnswer.Text = "";
            Checkmark.Visible = false;
            AnswerLabel.Visible = false;

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
                Checkmark.Text = CHECKMARK;
                Checkmark.ForeColor = GREEN_COLOR;
                Checkmark.Font = CHECKMARK_FONT;
                Checkmark.Visible = true;
            }
            else
            {
                Checkmark.Text = RED_CROSS;
                Checkmark.ForeColor = RED_COLOR;
                Checkmark.Font = CROSS_FONT;
                Checkmark.Visible = true;
            }

            AnswerLabel.Text = Answer;
            AnswerLabel.Visible = true;
        }

        public bool ValidateAnswer()
        {
            bool correct = false;

            switch (QuestionType)
            {
                case QuestionFlag.DenaryToBinary:
                case QuestionFlag.BinaryToDenary:
                    correct = Validators.CheckBinaryDenary(UserAnswer.Text, Answer);
                    break;
                case QuestionFlag.BinaryToHex:
                    correct = Validators.CheckHex(UserAnswer.Text, Answer);
                    break;
                case QuestionFlag.HexToBinary:
                    correct = Validators.CheckBinaryDenary(UserAnswer.Text, Answer);
                    break;
                case QuestionFlag.DenaryToHex:
                    correct = Validators.CheckHex(UserAnswer.Text, Answer);
                    break;
                case QuestionFlag.HexToDenary:
                    correct = Validators.CheckBinaryDenary(UserAnswer.Text, Answer);
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
}