using System;
using System.Text;

namespace ConvertNumbersApp
{
    public static class Converters
    {

        /// <summary>
        /// Converts an integer to the equivalent binary string.
        /// </summary>
        /// <param name="denary">Integer (between 0 and 255)</param>
        /// <returns>Equivalent binary string.</returns>
        public static string DenaryToBinary(int denary, bool format = false)
        {
            // Check if the integer given fits what is required.
            if (denary > 255)
                throw new ArgumentException("Denary cannot be larger than the unsigned byte max value (255)");
            else if(denary < 0)
                throw new ArgumentException("Denary cannot be less than the unsigned byte min value (0)");

            // Algorithm to create binary string from integer
            StringBuilder binary = new();
            while (denary > 0)
            {
                binary.Insert(0, $"{denary % 2}");
                denary /= 2;
            }
            if(format)
            {
                binary.Insert(0, "0", 8 - binary.Length);
                binary.Insert(4, " ");
            }

            return binary.ToString();
        }

        /// <summary>
        /// Converts an 8 bit binary string into the equivalent integer.
        /// </summary>
        /// <param name="binary">8 bit binary string</param>
        /// <returns>Equivalent integer.</returns>
        public static int BinaryToDenary(string binary)
        {
            // Binary string can't be larger than 8 (8 bits)
            if (binary.Length > 8)
                throw new ArgumentException("Binary cannot be larger than 1 byte (8 bits)");

            // Algorithm to get the denary value of a binary string (only works on unsigned)
            int denary = 0;
            int multiplier = 1;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == ' ')
                    continue;
                denary += multiplier * int.Parse(binary[i] + "");
                multiplier *= 2;
            }

            return denary;
        }

        /// <summary>
        /// Simple function to return the Hex equivalent of an integer.
        /// </summary>
        /// <param name="denary"></param>
        /// <returns></returns>
        public static string DenaryToHex(int denary)
        {
            // Integer has a built in function but better to have an abstracted function to include .ToString("X").
            return denary.ToString("X");
        }
    }
}
