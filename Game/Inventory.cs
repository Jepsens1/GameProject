using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Inventory
    {

        public string ViewInventory(Player player)
        {
            if (player.Backpack.items.Count == 0)
            {
                return $"Empty";
            }
            else
            {
                for (int i = 0; i < player.Backpack.items.Count; i++)
                {

                    return player.Backpack.items[i].Name + player.Backpack.items[i].Price;
                }
            }
            
            return null;
        }
    }
}
