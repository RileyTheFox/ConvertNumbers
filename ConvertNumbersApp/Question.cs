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
        public TextBox Text;
        public TextBox UserAnswer;
        public Label Checkmark;

        private string Answer;
        
        public Question(Label label, TextBox text, TextBox userAnswer, Label checkmark)
        {
            Label = label;
            Text = text;
            UserAnswer = userAnswer;
            Checkmark = checkmark;

            QuestionType type = (QuestionType)new Random().Next(0, 6);

            switch (type)
            {
                case QuestionType.DenaryToBinary:
                    int denary = new Random().Next(266);
                    string binaryAnswer = Converters.DenaryToBinary(denary);

                    Answer = binaryAnswer;
                    break;
                case QuestionType.BinaryToDenary:
                    break;
                case QuestionType.BinaryToHex:
                    break;
                case QuestionType.HexToBinary:
                    break;
                case QuestionType.DenaryToHex:
                    break;
                case QuestionType.HexToDenary:
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
}