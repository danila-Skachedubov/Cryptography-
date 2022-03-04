using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptographypractice1
{
    class MonomorphicDictionary
    {
        List<char> dictionary = new List<char>();
        public Dictionary<char, string> table = new Dictionary<char, string>();

        public void CalculateFrequency(string input)
        {
            for (int i = 0; i < 127; i++)
            {
                dictionary.Add((char)i);
            }
            Random rand = new Random();
            byte a = 0;
            for (int i = 0; i < input.Length; i++)
            {
                a = (byte)rand.Next(33, 127);
                table.Add(dictionary[a], input[i].ToString());
                dictionary.RemoveAt((int)a);
            }
            string shifr = string.Empty;
            foreach (var item in table)
            {
                shifr += item.Key.ToString();
            }
            Console.WriteLine(shifr);
        }  

        public void Decryption(string input)
        {
            if (table.Count == 0)
                Console.WriteLine("Таблица не заполнена, введите слово для шифровки");
            else
            {
                string output = string.Empty;
                foreach (var item in table)
                {
                    output += item.Value;
                }
                Console.Write(output);
            }
        }
    }
}
