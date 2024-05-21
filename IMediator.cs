using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public interface IMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);
    }

}
