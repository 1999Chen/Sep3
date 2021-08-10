using System.Collections.Generic;
using Sep3Tier3.Models;

namespace Sep3Tier3.Data
{
    public interface IMessageService
    {
        List<Message> getAllMessages();
        List<Message> GetMessages(string username1, string username2);
        Message sendMessage(Message Message);
    }
}