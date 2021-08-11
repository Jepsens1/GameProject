using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Backpack
    {
        public List<Item> items { get; set; }
        public Backpack()
        {
            items = new List<Item>();
        }
    }
}
