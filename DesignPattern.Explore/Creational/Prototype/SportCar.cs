using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Creational.Prototype
{
    public class SportCar : CarPrototype
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public override CarPrototype Clone()
        {
            return (CarPrototype)MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine("Brand {0}", Brand);
            Console.WriteLine("Model {0}", Model);
        }
    }
}
