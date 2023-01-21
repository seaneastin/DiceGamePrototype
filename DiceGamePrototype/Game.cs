using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGamePrototype
{
    class Game
    {
        string playerchoice; //this is used by many functions in the program
        string playerchoice2; //this is used by many functions in the program
        bool validchoice = false; //this is used for the while loops used in the menus to prevent players from picking an invalid chocie
        bool gameisrunning = true; //tells the program if the game is currently running
        public void Start()
        {
            Menu();
        }
        void Menu()
        {
            while (gameisrunning)
            {
                validchoice = false;
                while (!validchoice)
                {
                    Console.WriteLine("1. Add Character");
                    Console.WriteLine("2. Remove Character");
                    Console.WriteLine("3. Characters");
                    Console.WriteLine("4. quit");

                    playerchoice = Console.ReadLine();
                    switch (playerchoice)
                    {
                        case "1":

                            break;
                        case "2":

                            break;
                        case "3":

                            break;
                        case "4":
                            gameisrunning = false;
                            validchoice = true;
                            break;
                    }
                }

            }


        }
    }
}
