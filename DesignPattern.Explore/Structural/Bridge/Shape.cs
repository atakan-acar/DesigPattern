using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Structural.Bridge
{
    abstract class Shape
    {
        protected IColor color;

        public Shape(IColor color)
        {
            this.color = color;
        }

        public abstract void Draw();
    }

    class Circle : Shape
    { 
        public Circle(IColor color) :base(color)
        { 
        }
        public override void Draw()
        {
            Console.Write("Drawing a circle with ");
            color.ApplyColor();
        }
    }


}
