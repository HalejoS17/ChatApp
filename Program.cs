using ChatApp;
using System;

class Program
{
    static void Main(string[] args)
    {
        IMediator mediator = new ChatMediator();

        User user1 = new ConcreteUser(mediator, "Alice");
        User user2 = new ConcreteUser(mediator, "Bob");
        User user3 = new ConcreteUser(mediator, "Charlie");

        mediator.RegisterUser(user1);
        mediator.RegisterUser(user2);
        mediator.RegisterUser(user3);

        user1.SendMessage("Hola a todos!");
        user2.SendMessage("Hola Alice!");
        user3.SendMessage("Buenos días a todos!");

        Console.ReadLine();
    }
}
