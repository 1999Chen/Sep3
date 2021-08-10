using System.Collections.Generic;
using Tier1.Model;

namespace Tier1.Data
{
    public interface IMessageService
    {
              List<Message> getAllMessages(string username1, string username2);
              void sendMessage(Message chatMessage);
              
              //buhuiba
    }
}