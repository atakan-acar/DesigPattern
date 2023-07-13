using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Creational.Prototype
{
    public class CarFactory
    {
        private static Dictionary<string, CarPrototype> prototypes = new Dictionary<string, CarPrototype>();

        public static void RegisterPrototype(string key, CarPrototype prototype)
        {
            prototypes[key] = prototype;
        }

        public static CarPrototype GetPrototype(string key)
        {
            if (prototypes.ContainsKey(key))
            {
                return prototypes[key].Clone();
            }
            return null;
        }
    }
}
