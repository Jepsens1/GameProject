using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Game
{
    class Player
    {
        public string Name { get; set; }
        public Backpack Backpack { get; set; }
        public int Balance { get; set; }
        public Weapon weapon { get; set; }
        public int Health { get; set; }

        public Player()
        {
            Health = 50;
            Name = "Steve";
            weapon = new Sword(SwordType.WoodenSword);
            Backpack = new Backpack();
            Balance = 50;
        }
        public override string ToString()
        {
            return $"Player: {Name}\nBalance: {Balance}\nBackpack count: {Backpack.items.Count}";
        }
        public void AttackEnemy(Enemy enemy)
        {
            enemy.Health -= weapon.Damage;
        }
        public string ShowBackPack()
        {
            string stuff = " ";
            if (Backpack.items.Count == 0)
            {
                return "Empty";
            }
            for (int i = 0; i < Backpack.items.Count; i++)
            {
                stuff += Backpack.items[i].Name;
            }
            return stuff;
        }
        public string Eat()
        {

            string userinput = Console.ReadLine();
            if (Backpack.items.Count != 0)
            {
                for (int i = 0; i < Backpack.items.Count; i++)
                {
                    switch (userinput)
                    {
                        case "1":
                            return TypeOfItem(0);
                        case "2":
                            return TypeOfItem(1);
                        case "3":
                            return TypeOfItem(2);
                        case "4":
                            return TypeOfItem(3);
                        default:
                            break;
                    }
                }
            }
            else
            {
                return "Empty";
            }
            return null;
        }
        string TypeOfItem(int userinput)
        {
            string stuff = "You have now eaten ";
            switch (Backpack.items[userinput].ItemType)
            {
                case Game.TypeOfItem.Fruit:
                    Health += 10;
                    stuff += Backpack.items[userinput].Name;
                    Backpack.items.RemoveAt(userinput);
                    break;
                case Game.TypeOfItem.Meat:
                    Health += 6;
                    stuff += Backpack.items[userinput].Name;
                    Backpack.items.RemoveAt(userinput);
                    break;
                default:
                    break;
            }
            return stuff;
        }
    }
}
