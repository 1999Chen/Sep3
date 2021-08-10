using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using Sep3Tier3.DataAccess;
using Sep3Tier3.Models;
using Sep3Tier3.DataAccess;
using Sep3Tier3.Models;

namespace Sep3Tier3.Data
{
    public class MessageService : IMessageService
    {
        sepDBContext dbcontext = new sepDBContext();
        private List<Message> Messages;

        public MessageService()
        {
            Messages = new List<Message>();
        }

        public List<Message> getAllMessages()
        {
            var list1 = dbcontext.Messages;
            var list = new List<Message>();

            foreach (var c in list1)
            {
                list.Add(c);
            }

            return list;
        }


        public List<Message> GetMessages(string username1, string username2)
        {
            var list1 = getAllMessages();
            var list = new List<Message>();
            foreach (var msg in list1)
            {
                if (msg.nameSend.Equals(username1) && msg.nameReceived.Equals(username2))
                {
                    list.Add(msg);
                }

                if (msg.nameSend.Equals(username2) && msg.nameReceived.Equals(username1))
                {
                    list.Add(msg);
                }
            }

            return list;
        }

        public Message sendMessage(Message Message)
        {
            int maxId = dbcontext.Messages.Max(m => m.id);

            Message newMessage = new Message
            {
                date = Message.date,
                nameReceived = Message.nameReceived,
                nameSend = Message.nameSend,
                message = Message.message,
                id = maxId + 1,
            };

            dbcontext.Messages.Add(newMessage);
            dbcontext.SaveChanges();
            return newMessage;
        }
    }
}