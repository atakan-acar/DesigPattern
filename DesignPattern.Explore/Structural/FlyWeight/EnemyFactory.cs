using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Structural.FlyWeight
{
    public class EnemyFactory
    {
        private IDictionary<string, IEnemy> _enemies = new Dictionary<string, IEnemy>();

        public IEnemy GetEnemy(string type, ConsoleColor color)
        {
            string key = $"{type}_{color}";

            if (this._enemies.ContainsKey(key))
            {
                return _enemies[key];
            }
            else
            {
                IEnemy enemy = new Enemy(type, color);
                _enemies.Add(key, enemy);
                return enemy;
            }
        }
    }
}
