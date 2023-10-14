using DesignPattern.Explore.Behavioar.Mediator;
using DesignPattern.Explore.Behavioar.Mediator.Concrete;
IChatMediator mediator = new ChatMediator();

User user = new User(mediator, "Atakan");
User user2 = new User(mediator, "Ayşe");
User user3 = new User(mediator, "Charlie");

mediator.AddUser(user);
mediator.AddUser(user2);
mediator.AddUser(user3);

user.Send("Hi Ayse");
user2.Send("Hi Charlie");
user3.Send("Hi Atakan");