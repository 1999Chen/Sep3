using System;
using System.Collections.Generic;
using Tier1.Model;

namespace Tier1.Services
{
 public class Client
{
    
    ISockets sockets=new Sockets();

    private static Client client = new Client();

    private Client()
    {
        Connect();
    }

    public static Client getInstance()
    {
        return client;
    }

    public void Connect()
    {
        sockets.Connect();
    }

    public User getUserInfo(string username)
    {
        return sockets.GetUserInfo(username);
    }

    public List<User> searchUsers(User searchUser)
    {

        return sockets.Search(searchUser);
    }

    public List<User> getAllUsers()
    {
        return sockets.getAllUsers();
    }
    
    public User ValidateUser(string username, string password)
    {
        
       string a= sockets.Login(username,password);
       if (a=="Login success")
           return new User
           {
               username = username,
               password = password
           };
       return null;
    }
    
    public string RegisterUser(string username, string password)
    {
        string result=sockets.Register(username, password);

        return result;
    }
    

    public void logout()
    {
        sockets.Logout();
    }

    public void editInfo(string username, string password,string firstname,string lastname, string hobbies,  string sex, string hometown, string description, string major, int age,DateTime birthday)
    {
        sockets.Edit(username, password, firstname, lastname, hobbies, sex, hometown, description, major, age,birthday);
    }
    
    
    public string currentName { get; set; }

    public List<FriendRequest> getFriends(string username1)
    {
        return sockets.GetFriendList(username1);

    }

    public void delete(string username1, string username2)
    {
        sockets.delete(username1,username2);
    }

    public string sendRequest(string usernameSend,string usernameReceive)
    {
        FriendRequest friend = new FriendRequest()
        {
            usernameSend = usernameSend,
            usernameReceive = usernameReceive,
            accept=false
        };
       return sockets.SendFriendRequest(friend);

    }

    public List<FriendRequest> getRequests(string username)
    {
       return sockets.GetRequest(username);

    }
    
    public void agree(FriendRequest friend)
    {
        sockets.agree(friend);
    }

    public void sendMessage(Message chatMessage)
    {
        sockets.sendMessage(chatMessage);
    }
    
    public List<Message> getAllMessages(string username1,string username2)
    {
        return sockets.getAllMessages(username1, username2);

    }
    
    
    
    
    
    
    
    
    
    
    
    
    

}

}