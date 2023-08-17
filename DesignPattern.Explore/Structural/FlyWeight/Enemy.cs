using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Structural.FlyWeight
{
    // ConcreteFlyweight sınıfı 
    public class Enemy : IEnemy
    {
        private string _type;
        private ConsoleColor _color;
        public Enemy(string type, ConsoleColor color)
        {
            _type = type;
            _color = color;
        }

        public void Display(int x, int y)
        {
            Console.ForegroundColor = _color;
            Console.WriteLine($"Enemy type:{_type} and position: ({x}, {y})");
            Console.ResetColor();
        }


    }
}
