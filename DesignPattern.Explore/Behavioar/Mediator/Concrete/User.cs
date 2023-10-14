using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Behavioar.Mediator.Concrete
{
    public class User
    {
        private IChatMediator mediator;

        public string Name { get; private set; }
        public User(IChatMediator chatMediator, string name)
        {
            this.mediator = chatMediator;
            Name = name;
        }


        public void Receive(string message)
        {
            Console.WriteLine($"{this.Name} received: {message}");
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            mediator.SendMessage(message, this);
        }
    }
}
