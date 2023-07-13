using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Creational.Builder
{
    public class PageBuilder
    {
        public PageBuilder SetHeader()
        {
            Console.WriteLine("Header Setted");
            return this;
        }

        public PageBuilder SetBody()
        {
            Console.WriteLine("Body Setted");
            return this;
        }

        public PageBuilder SetFooter()
        {
            Console.WriteLine("Footer Setted");
            return this;
        }

        public Page Page()
        {

            return new Page
            {
                Body = "",
                Footer = "",
                 Header = ""
            };
        }
    }
}
