using System.Collections.Generic;
using Tier1.Model;
using Tier1.Services;

namespace Tier1.Data
{
    public class MessageService:IMessageService
    {
           public List<Message> getAllMessages(string username1,string username2)
               {
                   return Client.getInstance().getAllMessages(username1, username2);
        
               }
        
               public void sendMessage(Message message)
               {
                   Client.getInstance().sendMessage(message);
                   
               }
    }
}