using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGamePrototype
{
    class Character
    {
        String _name = "name here";
        String _description = "friend";
        List<Item> _iventory = new List<Item>();
        int _strength;
        int _dexterity;
        int _constituion;
        int _intelligence;
        int _wisdom;
        int _charisma;
        public void Test()
        {
            Item test = new Item();
            _iventory.Add(test);
            Console.ReadLine();
        }
        public void printCharacter()
        {
            Console.WriteLine("Name: " + _name + " Strength: " + _strength + " Dexterity: " + _dexterity + 
                " constitution: " + _constituion + " Intelligence: " + _intelligence +
                " Wisdom: " + _wisdom + " charisma: " + _charisma + "\n" + _description);
        }
        public void printInventory()
        {
            for (int i = 0; i < _iventory.Count; i++)
            {
                Console.WriteLine(_iventory[i].GetName() + ",");
            }
        }
    }
}
