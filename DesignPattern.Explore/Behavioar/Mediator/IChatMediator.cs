using DesignPattern.Explore.Behavioar.Mediator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Behavioar.Mediator
{
    public interface IChatMediator
    {
        void SendMessage(string message, User user);

        void AddUser(User user);
    }
}
