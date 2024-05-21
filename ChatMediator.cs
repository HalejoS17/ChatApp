using ChatApp;
using System.Collections.Generic;

public class ChatMediator : IMediator
{
    private List<User> _users;

    public ChatMediator()
    {
        _users = new List<User>();
    }

    public void RegisterUser(User user)
    {
        if (!_users.Contains(user))
        {
            _users.Add(user);
        }
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in _users)
        {
            // No enviar el mensaje al remitente
            if (user != sender)
            {
                user.ReceiveMessage(message);
            }
        }
    }
}
