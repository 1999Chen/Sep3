using System;
using System.Collections.Generic;
using Tier1.Model;

namespace Tier1.Services
{
    public interface ISockets
    {
        void Connect();
        
        string  Login(string username, string password);

        string Register(string username, string password);
        
        string Edit(string username, string password, string firstname, string lastname, string hobbies,
            string sex, string hometown, string description, string major, int age,DateTime birthday);

        public User GetUserInfo(string username);

        List<Message> getAllMessages(string usernameSend, string usernameRecv);
        
        void Logout();

        List<FriendRequest> GetFriendList(string username1);

        void sendMessage(Message chatMessage);
        
   

        void delete(string usernameSend, string usernameReceive);

        string SendFriendRequest(FriendRequest friend);

        List<User> Search(User user);

        List<FriendRequest> GetRequest(string usernameSend);
        
        string agree(FriendRequest friend);

        List<User> getAllUsers();

    }
}