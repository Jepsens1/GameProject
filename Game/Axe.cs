using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    enum AxeType
    {
        Wooden,
        Stone,
        Iron,
        Golden
    }
    class Axe : Weapon
    {
        public AxeType axeType { get; set; }

        public Axe(AxeType axe)
        {
            axeType = axe;
            GetAxe();
        }
        void GetAxe()
        {
            switch (axeType)
            {
                case AxeType.Wooden:
                    Damage = 2;
                    Durability = 4;
                    break;
                case AxeType.Stone:
                    Damage = 3;
                    Durability = 6;
                    break;
                case AxeType.Iron:
                    Damage = 5;
                    Durability = 12;
                    break;
                case AxeType.Golden:
                    Damage = 8;
                    Durability = 15;
                    break;
                default:
                    break;
            }
        }
    }
}
