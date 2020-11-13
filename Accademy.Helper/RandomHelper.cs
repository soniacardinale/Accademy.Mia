using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Helper
{
    public class RandomHelper
    {
        /// <summary>
        /// example = "11011001" -> 217
        /// </summary>
        /// <param name="binaryString"></param>
        /// <returns></returns>
        public static int ConvertBynaryToInt(string binaryString)
        {
            int[] binary_Array = new int[binaryString.Length];
            bool error = false;
            // verify binaryString contains ONLY "1" or "0"
            for (int i = binaryString.Length - 1; i >= 0; i--)
            {
                if (binaryString[i] == '0' || binaryString[i] == '1')
                {
                    string bit_string = binaryString.Substring(i, 1);

                    binary_Array[binaryString.Length - i - 1] = Int32.Parse(bit_string);
                }
                else
                {
                    error = true;
                }
            }
            int tot = 0;

            for (int i = 0; i < binary_Array.Length; i++)
            {
                int binary_digit = binary_Array[i];
                tot += binary_digit * (int)(Math.Pow(2, i));
            }
            return tot;
        }
        /// <summary>
        /// Get a random value in a range
        /// </summary>
        /// <param name="min">min range value</param>
        /// <param name="max">max range value</param>
        /// <exception cref="Accademy.Helper.RandomArgumentsException">Thrown when min value is greater then max value</exception>
        /// <returns>random int in a range</returns>
        public static int GetRandomInt(int min, int max)
        {
            if (min > max)
            {
                throw new RandomArgumentsException();
            }
            else
            {
                int seed = Guid.NewGuid().GetHashCode();
                Random r = new Random(seed);
                //Random r = new Random();
                return r.Next(min, max);
            }

        }
        public static int GetSameint(int sameint)
        {
            return sameint;
        }
        public static string GetNumConto(int numChars)
        {
            string cc = "";
            if (numChars <= 36)
            {
                Guid newGuid = Guid.NewGuid();
                string s_newGuid = newGuid.ToString();
                cc = s_newGuid.Substring(0, numChars);

            }
            return cc;
        }

    }
}
