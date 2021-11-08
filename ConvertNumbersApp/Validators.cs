using System.Text.RegularExpressions;

namespace ConvertNumbersApp
{
    public static class Validators
    {

        /// <summary>
        /// Performs a Regex operation on the input using the answer string to check if it matches binary or denary format (leading 0s)
        /// </summary>
        /// <param name="input">The user input.</param>
        /// <param name="answer">The correct answer.</param>
        /// <returns>True: If the input matches the Regex.</returns>
        public static bool CheckBinaryDenary(string input, string answer)
        {
            return Regex.IsMatch(input.Replace(" ", ""), $"^0*({answer})$", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Performs a Regex operation on the input using the answer string to check if it matches hexadecimal format (with or without 0x)
        /// </summary>
        /// <param name="input">The user input.</param>
        /// <param name="answer">The correct answer.</param>
        /// <returns>True: If the input matches the Regex.</returns>
        public static bool CheckHex(string input, string answer)
        {
            return Regex.IsMatch(input, $"^(0x)?({answer})$", RegexOptions.IgnoreCase);
        }

    }
}
