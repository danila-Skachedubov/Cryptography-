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
            Dictionary<int, char> SymbolOfNumber = new Dictionary<int, char>();
            int[] arr = key.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
            

            for (int i = 0; i < input.Length; i++)
            {
                SymbolOfNumber.Add(i, input[i]);
            }
            for (int i = 0; i < SymbolOfNumber.Count; i++)
            {
                
                    Console.WriteLine(SymbolOfNumber[arr[i]]); 
                
            }
                         
        }
    }  
}
