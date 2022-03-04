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
        public string Encryption(string Input, string key)
        {
            string output = string.Empty;
            byte[] mass = new byte[Input.Length];
            byte[] mass2 = new byte[key.Length];

            mass = WordNumbering(Input);
            mass2 = KeyNumbering(key);

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
                string symbolOfSlovar = dictionatry[positionOfOutput].ToString();   //slovar[positionOfOutput].ToString();
                output = output.Insert(i, symbolOfSlovar);
            }
            Console.WriteLine(output);
            return output;
        }

        private byte[] WordNumbering(string input)
        {
            input.ToUpper();
            char[] slovar = dictionatry.ToCharArray();
            byte[] mass = new byte[input.Length];

            for (int j = 0; j < input.Length; j++)
            {
                int positionOfWord = dictionatry.IndexOf(input[j]);
                if (dictionatry.IndexOf(input[j]) == -1)
                {
                    //значения не соответсвующие словарю итгнорируются? как лучше сделать оставлять пробелы и знаки препинания или игнорировать?
                    continue;
                }
                else
                    mass[j] = (byte)positionOfWord;
            }
            return mass;
        }

        private byte[] KeyNumbering(string key)
        {
            key.ToUpper();
            byte[] mass2 = new byte[key.Length];
            for (int k = 0; k < key.Length; k++)
            {
                int positionOfKey = dictionatry.IndexOf(key[k]);
                mass2[k] = (byte)positionOfKey;
            }
            return mass2;
        }

        public string Decryption(string shifr, string key)
        {
            byte[] massOfShifr = new byte[shifr.Length];
            byte[] massOfKey = new byte[key.Length];
            string output = string.Empty;
            massOfShifr = WordNumbering(shifr);
            massOfKey = KeyNumbering(key);

            int counter = 0;
            for (int i = 0; i < shifr.Length; i++)
            {
                if (counter >= key.Length) counter = 0;
                int positionOfOutput = 0;
                positionOfOutput = (massOfShifr[counter] - massOfKey[i] + 25) % 25;
                counter++;
                string symbolOfSlovar = dictionatry[positionOfOutput].ToString();   //slovar[positionOfOutput].ToString();
                output = output.Insert(i, symbolOfSlovar);
            }
            Console.WriteLine(output);
            return output;
        }
    }
}
