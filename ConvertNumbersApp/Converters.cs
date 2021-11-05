using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumbersApp
{
    public static class Converters
    {

        public static string DenaryToBinary(int denary)
        {
            if (denary > 255)
                throw new ArgumentException("Denary cannot be larger than the unsigned byte max value (255)");
            else if(denary < 0)
                throw new ArgumentException("Denary cannot be less than the unsigned byte min value (0)");

            string binary = "";
            while (denary > 0)
            {
                binary = $"{denary % 2}" + binary;
                denary /= 2;
            }

            return binary;
        }

        public static int BinaryToDenary(string binary)
        {
            if (binary.Length > 8)
                throw new ArgumentException("Binary cannot be larger than 1 byte (8 bits)");

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
    }
}
