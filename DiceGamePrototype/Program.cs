using System;

namespace DiceGamePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("Hello World!");
            Character Test = new Character();
            Test.Test();
            Test.printCharacter();
            Console.ReadLine();
            game.Start();
        }


    }
}
