using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptographypractice1
{
    class Permutation
    {
        public void Encryption(string input, string key)
        {
            string[] output = new string[input.Length];
            int[] arr = key.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();

            /*if (input.Length / key.Length != 0)
             {
                int add = key.Length - (input.Length % key.Length);
                for (int i = 0; i < add; i++)
                {
                    input += input[i];
                }
             }*/ //если не получится сделать полный оборот ключем, например букв 5 а ключ 4

            char[] arrOfInput = input.ToCharArray();
            string result = "";
            for (int i = 0; i < input.Length; i += key.Length)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i + j >= arrOfInput.Length) break;
                    output[arr[j]] = arrOfInput[j + i].ToString();

                }
                for (int j = 0; j < key.Length; j++)
                    result += output[j];
            }

            Console.WriteLine(result);
        }

        public void Deryption(string shifr, string key)
        {
            string result = "";
            int[] arr = key.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
            for (int i = 0; i < shifr.Length; i += key.Length)
            {
                char[] transposition = new char[key.Length];

                for (int j = 0; j < key.Length; j++)
                    transposition[j] = shifr[i + arr[j]];

                for (int j = 0; j < key.Length; j++)
                    result += transposition[j];
            }

            Console.WriteLine(result);
        }
    }
}
