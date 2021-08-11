using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    enum MeatType
    {
        Beef,
        Chicken,
        Lamb,
        Turkey,
        Pork
    }
    class Meat : Item
    {
        public MeatType meatTypes { get; set; }
        public Meat(string name,TypeOfItem ofItem, MeatType meat) : base(name, ofItem)
        {
            meatTypes = meat;
            GetMeat();
        }
        void GetMeat()
        {
            switch (meatTypes)
            {
                case MeatType.Beef:
                    Price = 8;
                    break;
                case MeatType.Chicken:
                    Price = 4;
                    break;
                case MeatType.Lamb:
                    Price = 12;
                    break;
                case MeatType.Turkey:
                    Price = 15;
                    break;
                case MeatType.Pork:
                    Price = 10;
                    break;
                default:
                    break;
            }
        }

    }
}
