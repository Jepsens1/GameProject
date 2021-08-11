using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Shop
    {
        public List<Item> items { get; set; }
        public Shop()
        {
            items = new List<Item>();
            items.Add(new Fruit("Apple", TypeOfItem.Fruit, FruitType.Apple));
            items.Add(new Fruit("Banana", TypeOfItem.Fruit, FruitType.Banana));
            items.Add(new Fruit("Pear", TypeOfItem.Fruit, FruitType.Pear));
        }
        public string ShowItem()
        {
            string stuff = "";
            if (items.Count == 0)
            {
                return "Shop is Empty";
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    stuff += $"{items[i].Name} Price: {items[i].Price}\n";
                }
                return stuff;
            }

        }
        public string ShowBackPack(Player player)
        {
            string backstuff = "";
            if (player.Backpack.items.Count == 0)
            {
                return "Empty";
            }
            for (int i = 0; i < player.Backpack.items.Count; i++)
            {
                backstuff += $"{player.Backpack.items[i].Name} Price: {player.Backpack.items[i].Price}\n";
            }
            return backstuff;
        }
        public void SellItem(Player player)
        {
            string userinput = Console.ReadLine();
            if (player.Backpack.items.Count != 0)
            {
                switch (userinput)
                {
                    case "1":
                        player.Balance += player.Backpack.items[0].Price;
                        items.Add(player.Backpack.items[0]);
                        player.Backpack.items.RemoveAt(0);
                        break;
                    case "2":
                        player.Balance += player.Backpack.items[1].Price;
                        items.Add(player.Backpack.items[1]);
                        player.Backpack.items.RemoveAt(1);
                        break;
                    case "3":
                        player.Balance += player.Backpack.items[2].Price;
                        items.Add(player.Backpack.items[2]);
                        player.Backpack.items.RemoveAt(2);
                        break;
                    default:
                        break;
                }
            }
            Console.Clear();
        }
        public void BuyItem(Player player)
        {
            string userinput = Console.ReadLine();
            if (player.Balance != 0)
            {
                switch (userinput)
                {
                    case "1":
                        player.Balance -= items[0].Price;
                        player.Backpack.items.Add(items[0]);
                        items.RemoveAt(0);
                        break;
                    case "2":
                        player.Balance -= items[1].Price;
                        player.Backpack.items.Add(items[1]);
                        items.RemoveAt(1);
                        break;
                    case "3":
                        player.Balance -= items[2].Price;
                        player.Backpack.items.Add(items[2]);
                        items.RemoveAt(2);
                        break;
                    default:
                        break;
                }
            }
            Console.Clear();
        }
    }
}
