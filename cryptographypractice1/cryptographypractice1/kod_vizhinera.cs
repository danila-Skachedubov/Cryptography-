using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptographypractice1
{
    class kod_vizhinera
    {
        private string input = string.Empty;
        private string key = string.Empty;
        public static string dictionatry = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public string Input { get => input; set => input = value; }

        public string Key1 { get => key; set => key = value; }

        public kod_vizhinera(string input, string key)
        {
            input = Input;
            key = Key1;
        }
        public void Encryption(string Input, string key)
        {
            string output = string.Empty;
            char[] slovar = dictionatry.ToCharArray();

            byte[] mass = new byte[Input.Length];
            byte[] mass2 = new byte[key.Length];

            Input.ToUpper();
            key.ToUpper();

            for (int j = 0; j < Input.Length; j++)
            {
                int positionOfWord = dictionatry.IndexOf(Input[j]);
                if (dictionatry.IndexOf(Input[j]) == -1)
                {
                    //значения не соответсвующие словарю итгнорируются? как лучше сделать оставлять пробелы и знаки препинания или игнорировать?
                    continue;
                }
                else
                    mass[j] = (byte)positionOfWord;
            }

            for (int k = 0; k < key.Length; k++)
            {
                int positionOfKey = dictionatry.IndexOf(key[k]);
                mass2[k] = (byte)positionOfKey;
            }
            int counter = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                if (counter >= key.Length) counter = 0;
                int positionOfOutput = 0;
                if (mass2[counter] + mass[i] > dictionatry.Length)
                    positionOfOutput = (mass2[counter] + mass[i]) - dictionatry.Length;
                else
                    positionOfOutput = (mass2[counter] + mass[i]) % 25;
                counter++;
                string symbolOfSlovar = slovar[positionOfOutput].ToString();
                output = output.Insert(i, symbolOfSlovar);
            }
            Console.WriteLine(output);
        }

        public void Decryption(string shifr, string key)
        {

        }
    }
}
