using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Structural.FlyWeight
{
    public class Game
    {
        private List<(int x, int y, IEnemy enemy)> _enemies = new List<(int x, int y, IEnemy enemy)>();

        public void SpawnEnemy(int x,int y, IEnemy enemy)
        {
            _enemies.Add((x, y, enemy));
        }

        public void DisplayEnemies()
        {
            foreach (var (x, y, enemy) in _enemies)
            {
                enemy.Display(x, y);
            }
        }
    }
}
