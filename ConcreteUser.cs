using ChatApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class ConcreteUser : User
{
    public ConcreteUser(IMediator mediator, string name) : base(mediator, name) { }

    public override void SendMessage(string message)
    {
        Console.WriteLine($"{_name} envía: {message}");
        _mediator.SendMessage(message, this);
    }

    public override void ReceiveMessage(string message)
    {
        Console.WriteLine($"{_name} recibe: {message}");
    }
}

