using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Kata
{
    public class KataClass
    {
        #region Kata 1 - Cyclic Permutations

        /// <summary>
        /// Implement the cyclic permutation method, the method should be able to output the full string of permutations
        /// given a set number n
        ///
        /// The results MUST NOT BE HARD CODED!
        ///
        /// Example:
        /// n = 5
        ///
        /// 12345
        /// 51234
        /// 45123
        /// 34512
        /// 23451
        ///
        /// n = 4
        ///
        /// 1234
        /// 4123
        /// 3412
        /// 2341
        ///
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public String CyclicPermutations(int number)
        {
            return "";
        }
        
        #endregion

        #region Kata 2 - Divisors

        // Kata 2
        /// <summary>
        /// Produce the divisors of a number n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] CalculateDivisors(int n)
        {
            return new int[0];
        }

        #endregion

        #region Kata 3 - Encryption / Decryption

        /// <summary>
        /// Figure out what type of encryption it is, then try to make the encryption
        /// and decryption methods pass the tests!
        /// </summary>
        /// <param name="word"></param>
        /// <param name="map"></param>
        /// <param name="shifts"></param>
        /// <returns></returns>
        public string Encrypter(string word, Dictionary<string, int> map, int shifts)
        {
            char[] toChars = word.ToCharArray();
            StringBuilder result = new StringBuilder();

            Dictionary<int, string> reverseMap = new Dictionary<int, string>();

            foreach (string str in map.Keys)
            {
                reverseMap.Add(map[str], str);
            }

            for (int i = 0; i < toChars.Length; i++)
            {
                int n = map[toChars[i] + ""];
                int totalShifts = (n + shifts);

                if (reverseMap.ContainsKey(totalShifts))
                {
                    result.Append(reverseMap[totalShifts]);
                }
                else
                {
                    result.Append(reverseMap[totalShifts - reverseMap.Count]);
                }
            }

            return result.ToString();
        }

        public string Decrypter(string encryptedWord, Dictionary<string, int> map, int shifts)
        {
            return "";
        }

        #endregion

        #region Kata 4 - FizzBuzz

        /// <summary>
        /// Goal: Print out on each line the numbers from 1 to the number specified, 
        /// with a few important caveats:
        /// 
        /// - If the number is a multiple of 3, print out the word 'Fizz' instead of the number
        /// - If the number is a multiple of 5, print out the word 'Buzz' instead of the number
        /// - If the number is a multiple of both 3 and 5, print out the word 'FizzBuzz' instead of the number
        /// 
        /// </summary>
        /// <returns></returns>
        public string PrintFizzBuzz(int number)
        {
            return "";
        }

    }

    #endregion
}