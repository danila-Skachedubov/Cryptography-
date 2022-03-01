using System;

namespace cryptographypractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            #region
            kod_vizhinera newKod = new kod_vizhinera("М", "к");
            /* newKod.Encryption("ATTACKATDAWN", "LEMONLEMONLE");
             newKod.Decryption("LXFOPVEFRNHR", "LEMONLEMONLE");*/
            #endregion
            #region
            Permutation newKod2 = new Permutation();
            //newKod2.Encryption("москва", "412035");
           // newKod2.Deryption("косвма", "412035");
            #endregion
            #region
            Xor xor = new Xor();
            //xor.Encryption("HELLO");
            xor.Decryption("DIWTD", "WDKHP");
            #endregion
        }
    }
}
