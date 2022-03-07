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

        public string CalculateFrequency(string input)
        {
            for (int i = 0; i < 127; i++)
            {
                dictionary.Add((char)i);
            }
            Random rand = new Random();
            byte a = 0;
            for (int i = 0; i < input.Length; i++)
            {

                int x = 127;
                a = (byte)rand.Next(33, x);
                table.Add(dictionary[a], input[i].ToString());
                dictionary.RemoveAt((int)a);
                x--;
            }
            string shifr = string.Empty;
            foreach (var item in table)
            {
                shifr += item.Key.ToString();
            }
            Console.WriteLine("Зашифрованное сообщение" + shifr);
            return shifr;
        }

        public string Decryption(string input)
        {
            if (table.Count == 0)
            {
                Console.WriteLine("Таблица не заполнена, введите слово для шифровки");
                return "0";
            }
            else
            {
                string output = string.Empty;
                foreach (var item in table)
                {
                    output += item.Value;
                }
                Console.WriteLine("Расшифрованное сообщение" + output);
                return output;
            }
        }
    }
}
