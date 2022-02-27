using System;

namespace cryptographypractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            kod_vizhinera newKod = new kod_vizhinera("М", "к");
            newKod.Encryption("ATTACKATDAWN", "LEMONLEMONLE");
            newKod.Decryption("LXFOPVEFRNHR", "LEMONLEMONLE");
        }
    }
}
