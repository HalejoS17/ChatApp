using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public abstract class User
    {
        protected IMediator _mediator;
        protected string _name;

        public User(IMediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }

        public abstract void SendMessage(string message);
        public abstract void ReceiveMessage(string message);
    }

}
