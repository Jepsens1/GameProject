using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    enum TypeOfItem
    {
        Fruit,
        Meat
    }
    class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public TypeOfItem ItemType { get; set; }
        public Item(string name, TypeOfItem ofItem)
        {
            ItemType = ofItem;
            Name = name;
        }

    }
}
