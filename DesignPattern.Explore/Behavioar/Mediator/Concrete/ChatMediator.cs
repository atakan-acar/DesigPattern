using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Explore.Behavioar.Mediator.Concrete
{
    public class ChatMediator : IChatMediator
    {
        private List<User> users = new List<User>();


        public void AddUser(User user)
        {
            bool isStartUser = users is not null;

            if (isStartUser)
            {
                users = new List<User>();
                users.Add(user);
            }
            users.Add(user);
        }
        public void SendMessage(string message, User user)
        {

            foreach (var u in users)
            {
                if(u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
