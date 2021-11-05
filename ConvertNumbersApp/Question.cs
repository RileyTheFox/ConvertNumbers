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

        private string Answer;
        
        public Question(Label label, TextBox text, TextBox userAnswer, Label checkmark)
        {
            Label = label;
            QuestionText = text;
            UserAnswer = userAnswer;
            Checkmark = checkmark;

            QuestionType type = (QuestionType)new Random().Next(0, 6);

            int denary = new Random().Next(266);

            switch (type)
            {
                case QuestionType.DenaryToBinary:
                    Label.Text = "Denary -> Binary";
                    QuestionText.Text = denary.ToString();
                    Answer = Converters.DenaryToBinary(denary);
                    break;
                case QuestionType.BinaryToDenary:
                    Label.Text = "Binary -> Denary";
                    QuestionText.Text = Converters.DenaryToBinary(denary);
                    Answer = denary.ToString();
                    break;
                case QuestionType.BinaryToHex:
                    Label.Text = "Binary -> Hex";

                    break;
                case QuestionType.HexToBinary:
                    Label.Text = "Hex -> Binary";

                    break;
                case QuestionType.DenaryToHex:
                    Label.Text = "Denary -> Hex";
                    QuestionText.Text = denary.ToString();

                    break;
                case QuestionType.HexToDenary:
                    Label.Text = "Hex -> Denary";

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void ValidateQuestion()
        {
            
        }
    }

    public enum QuestionType
    {
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