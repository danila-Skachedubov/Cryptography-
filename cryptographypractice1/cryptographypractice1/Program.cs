using System;

namespace cryptographypractice1
{
    class Program
    {
        public delegate void helper(string input, string key);
        static void Main(string[] args)
        {
           
        Console.WriteLine("Введите слово для шифрования");
            string input = Console.ReadLine();
            input.ToUpper();
            string key = string.Empty;
            string word = "Hello";
            Console.WriteLine("Выберите метод шифрования:" + Environment.NewLine +
                "1 - Шифр Виженера" + Environment.NewLine +
                "2 - Шифр перестанвоки" + Environment.NewLine +
                "3 - Шифр гаммирования входной последовательности" + Environment.NewLine +
                "4 - Шифр мономорфной таблицы" + Environment.NewLine +
                "0 - Выход");
            byte shifr = 0;

;            sbyte choice = 1;
            do
            {
                shifr = byte.Parse(Console.ReadLine());
                switch (shifr)
                {
                    case 1:
                        kod_vizhinera newKod = new kod_vizhinera();
                        key = Console.ReadLine().ToUpper();
                        word = newKod.Encryption(input, key);
                        newKod.Decryption("LXFOPVEFRNHR", "LEMONLEMONLE");
                        break;
                    case 2:
                        Permutation newKod2 = new Permutation();
                        newKod2.Encryption("москва", "412035");
                        newKod2.Deryption("косвма", "412035");
                        break;
                    case 3:
                        Xor xor = new Xor();
                        xor.Encryption("HELLO");
                        xor.Decryption("DIWTD", "WDKHP");
                        break;
                    case 4:
                        MonomorphicDictionary neww = new MonomorphicDictionary();
                        neww.CalculateFrequency("aboba");
                        neww.Decryption("aboba");
                        break;
                    case 0:
                        Console.WriteLine("Операция закончена");
                        break;
                    default:
                        break;
                }
            } while (choice != 0); 
             void InputWord()
            {
                Console.WriteLine("Слово для ввода:" + );

            }
        }
    }
}
