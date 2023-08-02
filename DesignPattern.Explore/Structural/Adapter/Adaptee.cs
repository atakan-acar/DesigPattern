using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Structural.Adapter
{
    public class Adaptee
    {
        public void SetSpesificHeader()
        {
            Console.WriteLine("Setted header");
        }
    }
}
