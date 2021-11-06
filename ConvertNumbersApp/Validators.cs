using System.Text.RegularExpressions;

namespace ConvertNumbersApp
{
    public static class Validators
    {

        public static bool CheckBinaryDenary(string input, string answer)
        {
            return Regex.IsMatch(input, $"^0*({answer})$", RegexOptions.IgnoreCase);
        }

        public static bool CheckHex(string input, string answer)
        {
            return Regex.IsMatch(input, $"^(0x)?({answer})$", RegexOptions.IgnoreCase);
        }

    }
}
