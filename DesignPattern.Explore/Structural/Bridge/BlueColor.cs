using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Structural.Bridge
{
    public class BlueColor: IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Blue color applied");
        }
    }
}
