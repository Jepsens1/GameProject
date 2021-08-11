using System;

namespace Game
{
    class Program
    {
        static Player player = new Player();
        static Fighting fighting = new Fighting();
        static Inventory inventory = new Inventory();
        static Shop shop = new Shop();
        static Enemy enemy = new Enemy("Bob", new Sword(SwordType.WoodenSword), 20);
        static void Main(string[] args)
        {
            StartScreen();
            Console.Read();
        }
        static void StartScreen()
        {
            Console.WriteLine("Welcome to the game");
            Console.WriteLine("1. Start game");
            string userinput = Console.ReadLine();
            if (userinput == "1")
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                Console.Clear();
                StartScreen();
            }
        }
        static void MainMenu()
        {

            Console.WriteLine("1.Fight\n2.Inventory\n3.Shop\n4.Exit");
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    Console.Clear();
                    FightScene();
                    break;
                case "2":
                    Console.Clear();
                    ViewInv();
                    break;
                case "3":
                    Console.Clear();
                    ShopMenu();
                    MainMenu();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        static void FightScene()
        {

            Console.WriteLine(fighting.Figthing(enemy, player));
        }
        static void ViewInv()
        {
            Console.WriteLine(inventory.ViewInventory(player));

        }
        static void ShopMenu()
        {
            
            Console.WriteLine("1.Buy Items\n2.Sell Items\n3.Back");
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    Console.Clear();
                    BuyItems();
                    break;
                case "2":
                    Console.Clear();
                    SellItems();
                    break;
                case "3":
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    break;
            }
        }
        static void SellItems()
        {
            Console.WriteLine(shop.ShowBackPack(player));
            shop.SellItem(player);
        }
        static void BuyItems()
        {
            Console.WriteLine(shop.ShowItem());
            shop.BuyItem(player);
        }
    }
}
