using System;

namespace cryptographypractice1
{
    class Program
    {
        public delegate void helper(string input, string key);
        static void Main(string[] args)
        {
            string input = string.Empty;
            string key = string.Empty;
            string word = "XBPDI";
            Console.WriteLine("Выберите метод шифрования:" + Environment.NewLine +
                "1 - Зашифровать: Шифр Виженера" + Environment.NewLine +
                "2 - Расшифровать: Шифр Виженера" + Environment.NewLine +
                "3 - Зашифровать: Шифр перестанвоки" + Environment.NewLine +
                "4 - Расшифровать: Шифр перестанвоки" + Environment.NewLine +
                "5 - Зашифровать:Шифр гаммирования входной последовательности" + Environment.NewLine +
                "6 - Шифр мономорфной таблицы" + Environment.NewLine +
                "0 - Выход");
            byte shifr = 0;

            ; sbyte choice = 1;
            do
            {
                Console.WriteLine("Выберите из меню");
                shifr = byte.Parse(Console.ReadLine());
                kod_vizhinera newKod = new kod_vizhinera();
                Permutation newKod2 = new Permutation();
                Xor xor = new Xor();
                MonomorphicDictionary neww = new MonomorphicDictionary();
                switch (shifr)
                {
                    case 1:
                        InputWord();
                        Console.WriteLine("Введите ключ ");
                        key = Console.ReadLine().ToUpper();
                        word = newKod.Encryption(input.ToUpper(), key);
                        break;
                    case 2:
                        Console.WriteLine("Введите ключ");
                        key = Console.ReadLine().ToUpper();
                        newKod.Decryption(word, key);//LXFOPVEFRNHR", "LEMONLEMONLE ATTACKATDOWN
                        break;
                    case 3:                       
                        InputWord();
                        Console.WriteLine("Введите ключ");
                        key = Console.ReadLine().ToUpper();
                        word = newKod2.Encryption(input.ToUpper(), key);//москва 012345                      
                        break;
                    case 4:
                        Console.WriteLine("Введите ключ");
                        key = Console.ReadLine().ToUpper();
                        word = newKod2.Deryption(word, key);//"косвма", "412035"
                        break;
                    case 5:                       
                        InputWord();
                        word = xor.Encryption(input.ToUpper());
                        xor.Decryption(word.ToUpper());
                        break;
                    case 6:
                        InputWord();                      
                        neww.CalculateFrequency(input);
                        neww.Decryption(input);
                        break;

                    case 0:
                        Console.WriteLine("Операция закончена");
                        break;
                    default:
                        break;
                }
            } while (choice != 0);

            string InputWord()
            {
                Console.WriteLine("Слово для ввода:" + word + Environment.NewLine + "Хотите изменить?" + Environment.NewLine +
                    "1 - да" + Environment.NewLine +
                    "2 - нет ");

                byte yesOrno = byte.Parse(Console.ReadLine());
                if (yesOrno == 1)
                {
                    Console.WriteLine("Введите слово для шифрования");
                    input = Console.ReadLine();
                }
                else
                {
                    input = word;
                }
                return input;
            }
        }
    }
}
