using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    enum FruitType
    {
        Apple,
        Banana,
        Pear,
    }
    class Fruit : Item
    {
        public FruitType fruitType { get; set; }
        public Fruit(string name,TypeOfItem ofitem, FruitType fruit) : base(name, ofitem)
        {
            fruitType = fruit;
            GetFruit();
        }
        void GetFruit()
        {
            switch (fruitType)
            {
                case FruitType.Apple:
                    Price = 5;
                    break;
                case FruitType.Banana:
                    Price = 7;
                    break;
                case FruitType.Pear:
                    Price = 10;
                    break;
            }
        }
    }
}
