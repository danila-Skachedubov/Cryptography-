using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptographypractice1
{
    class Xor
    {
        private static string dictionatry = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string Encryption(string input)
        {           
            input.Insert(0, " ");
           byte[] mass1 =  WordNumbering(input);
           byte[] mass2 =  Random(input);
           byte[] mass3 = new byte[input.Length];
           string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (mass1[i] + mass2[i] >= 27) mass3[i] = (byte)((mass1[i] + mass2[i]) - (byte)dictionatry.Length);
                else
                mass3[i] = (byte)(mass1[i] + mass2[i]);
                output += dictionatry[mass3[i]];
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
        public byte[] Random(string input)
        {
            Random rnd = new Random();
            string key = string.Empty;
            byte[] arr = new byte[input.Length];            
            for (int i = 0; i < input.Length; i++)
            {
                int value = rnd.Next(1, 26);
                arr[i] = (byte)value;
                key += dictionatry[value];
            }
            Console.WriteLine("Key is:" + key);
            return arr;
        }

        public string Decryption(string shifr, string key)
        {
            byte[] mass1 = WordNumbering(shifr);
            byte[] mass2 = WordNumbering(key);
            byte[] mass3 = new byte[shifr.Length];
            string output = string.Empty;
            for (int i = 0; i < shifr.Length; i++)
            {
                if (mass1[i] - mass2[i] <= 0)  mass3[i] = (byte)((mass1[i] - mass2[i]) + (byte)dictionatry.Length);
                else
                    mass3[i] = (byte)(mass1[i] - mass2[i]);
                output += dictionatry[mass3[i]];
            }
            Console.WriteLine(output);
            return output;
        }
    }
}
