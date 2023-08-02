using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Structural.Adapter
{
    public class Adapter : ITarget
    {
        private Adaptee specAdaptee;

        public Adapter(Adaptee specAdaptee)
        {
            this.specAdaptee = specAdaptee;
        }

        public void Request()
        {
            specAdaptee.SetSpesificHeader();
        }
    }
}
