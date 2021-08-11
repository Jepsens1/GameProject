using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Enemy
    {
        public string Name { get; set; }
        public Weapon weapon { get; set; }
        public int Health { get; set; }

        public Enemy(string name, Weapon _weapon, int health)
        {
            Name = name;
            weapon = _weapon;
            Health = health;
        }
        public void AttackPlayer(Player player)
        {
            player.Health -= weapon.Damage;
        }

    }
}
