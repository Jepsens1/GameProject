using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    enum SwordType
    {
        WoodenSword,
        StoneSword,
        IronSword,
        GoldenSword
    }
    class Sword : Weapon
    {
        public SwordType swordType { get; set; }

        public Sword(SwordType sword)
        {
            swordType = sword;
            GetSword();
        }
        void GetSword()
        {
            switch (swordType)
            {
                case SwordType.WoodenSword:
                    Durability = 4;
                    Damage = 3;
                    break;
                case SwordType.StoneSword:
                    Durability = 6;
                    Damage = 4;
                    break;
                case SwordType.IronSword:
                    Durability = 9;
                    Damage = 9;
                    break;
                case SwordType.GoldenSword:
                    Durability = 15;
                    Damage = 12;
                    break;
            }
        }
    }
}
