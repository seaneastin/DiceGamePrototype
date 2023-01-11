using System;

namespace DiceGamePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Character Test = new Character();
            Test.Test();
            Test.printCharacter();

            Console.ReadLine();
        }
    }
}
