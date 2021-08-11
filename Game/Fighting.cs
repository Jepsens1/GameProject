using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Fighting
    {
        public string Figthing(Enemy enemy, Player player)
        {
            bool PlayerTurn = false;
            while (player.Health >= 0 || enemy.Health >= 0)
            {
                PlayerTurn = !PlayerTurn;
                if (PlayerTurn)
                {
                    player.AttackEnemy(enemy);
                }
                else
                {
                    enemy.AttackPlayer(player);
                }
                if (player.Health <= 0)
                {
                    return $"Player died";
                }
                else if (enemy.Health <= 0)
                {
                    return $"Enemy died";
                }
            }
            return "";
        }
    }
}
