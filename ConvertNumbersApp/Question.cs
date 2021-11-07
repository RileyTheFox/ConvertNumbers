using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConvertNumbersApp
{
    public class Question
    {
        // Some constants/readonly fields for updating labels and text boxes
        private const string CHECKMARK = "🗸";
        private const string RED_CROSS = "❌";

        private readonly Color GREEN_COLOR = Color.FromArgb(0, 128, 0);
        private readonly Color RED_COLOR = Color.FromArgb(220, 20, 60);

        private readonly Font CHECKMARK_FONT = new("Microsoft Sans Serif", 16f, FontStyle.Regular);
        private readonly Font CROSS_FONT = new("Microsoft Sans Serif", 7, FontStyle.Regular);

        // All the UI elements associated with this question.
        public Label Label;
        public TextBox QuestionText;
        public TextBox UserAnswer;
        public Label Checkmark;
        public Label AnswerLabel;

        // Type of question and the answer to it
        private readonly QuestionFlag QuestionType;
        private readonly string Answer;

        /// <summary>
        /// Constructor for the Question, takes in all the UI elements, a Random reference and the type of question (if left Default it will be random)
        /// </summary>
        /// <param name="label">Question Label object.</param>
        /// <param name="text">Question Text object.</param>
        /// <param name="userAnswer">Text Box for the User's Answer.</param>
        /// <param name="checkmark">Label for the checkmark/cross to display.</param>
        /// <param name="answerLabel">Label for the correct answer.</param>
        /// <param name="random">Reference to the random generator.</param>
        /// <param name="type">Type of Question to create.</param>
        public Question(Label label, TextBox text, TextBox userAnswer, Label checkmark, Label answerLabel, ref Random random, QuestionFlag type = QuestionFlag.Default)
        {
            // Setting the local variables to the class fields
            Label = label;
            QuestionText = text;
            UserAnswer = userAnswer;
            Checkmark = checkmark;
            AnswerLabel = answerLabel;
            QuestionType = type;

            // Clearing text box, hiding the answer and checkmark
            UserAnswer.Text = "";
            Checkmark.Visible = false;
            AnswerLabel.Visible = false;

            // If the QuestionFlag is Default, we generate a random question type (Default == -1)
            if(type == QuestionFlag.Default)
                QuestionType = (QuestionFlag)random.Next(0, 6);

            int denary = random.Next(256);

            // Do the conversions for the question flag
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

        /// <summary>
        /// Marks the question. Displays the checkmark/cross and answer label.
        /// </summary>
        public void MarkQuestion()
        {
            // Check if the answer is correct
            if (ValidateAnswer())
            {
                // Set the text to a checkmark, green color and the font for the checkmark
                Checkmark.Text = CHECKMARK;
                Checkmark.ForeColor = GREEN_COLOR;
                Checkmark.Font = CHECKMARK_FONT;
                // Reveal it to the user
                Checkmark.Visible = true;
            }
            else
            {
                // Set the text to a cross, red color and the font for the cross
                Checkmark.Text = RED_CROSS;
                Checkmark.ForeColor = RED_COLOR;
                Checkmark.Font = CROSS_FONT;
                // Reveal it to the user
                Checkmark.Visible = true;
            }

            // Set the text of the answer label to the correct answer and reveal it
            AnswerLabel.Text = Answer;
            AnswerLabel.Visible = true;
        }

        /// <summary>
        /// Runs some checks to see if the inputted answer is the correct answer for this Question.
        /// </summary>
        /// <returns>True: The answer is correct. False: The answer is incorrect.</returns>
        private bool ValidateAnswer()
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

    /// <summary>
    /// Flags for the type of Question. Default = -1 and is used for random generation
    /// </summary>
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