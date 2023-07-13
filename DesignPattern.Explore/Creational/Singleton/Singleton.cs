using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        public Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public string Message { get; set; }
    }
}
