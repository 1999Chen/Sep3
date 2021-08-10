using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using Tier1.Model;
using tier1.Services;

namespace Tier1.Services
{
    public class Sockets : ISockets
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        
        public void Connect()
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8500);
            socket.Connect(ipEndPoint);
            Console.WriteLine("Connect success!");
        }

        public string SendAndReceive(Request request)
        {
            Thread.Sleep(100);
            var json = JsonSerializer.Serialize(request);
            Console.WriteLine("send:" + json);
            byte[] bytes = Encoding.UTF8.GetBytes(json + ";");
            socket.Send(bytes);
            string recv = "";
            byte[] recvBytes = new byte[1024];
            int bytesa;
            bytesa = socket.Receive(recvBytes, recvBytes.Length, 0);
            recv += Encoding.UTF8.GetString(recvBytes, 0, bytesa);
            Console.WriteLine("receive ok " + recv);
            // return JsonSerializer.Deserialize(recv);
            return recv;
        }
        
        public string Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public string Register(string username, string password)
        {
            Request request = new Request()
            {
                Type = RequestTypes.REGISTER.ToString(),
                Args = new User {username = username, password = password}
            };
            string recv = SendAndReceive(request);

            Console.WriteLine("guys come on look here------------"+recv);
            
            return recv;
            // Message message = JsonSerializer.Deserialize<Message>(recv);
            
            // return message.ToString();
        }

        public string Edit(string username, string password, string firstname, string lastname, string hobbies, string sex,
            string hometown, string description, string major, int age, DateTime birthday)
        {
            throw new NotImplementedException();
        }

        public User GetUserInfo(string username)
        {
            throw new NotImplementedException();
        }

        public List<Message> getAllMessages(string usernameSend, string usernameRecv)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public List<FriendRequest> GetFriendList(string username1)
        {
            throw new NotImplementedException();
        }

        public void sendMessage(Message chatMessage)
        {
            throw new NotImplementedException();
        }

        public void delete(string usernameSend, string usernameReceive)
        {
            throw new NotImplementedException();
        }

        public string SendFriendRequest(FriendRequest friend)
        {
            throw new NotImplementedException();
        }

        public List<User> Search(User user)
        {
            throw new NotImplementedException();
        }

        public List<FriendRequest> GetRequest(string usernameSend)
        {
            throw new NotImplementedException();
        }

        public string agree(FriendRequest friend)
        {
            throw new NotImplementedException();
        }

        public List<User> getAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}