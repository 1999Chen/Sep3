using System;
using System.Collections.Generic;
using Tier1.Data;
using Tier1.Model;
using Tier1.Services;

namespace Tier1.Data
{
    public class UserService:IUserService
    {
        public UserService()
        {
            
        }

        public void Connect()
        {
            // Client.getInstance().Connect();
        }

        public User getUserInfo(string username)
        {
            return Client.getInstance().getUserInfo(username);
            
        }
    
    
        public User ValidateUser(string username, string password)
        {

            return Client.getInstance().ValidateUser(username, password);

        }

        public List<User> getAllUsers()
        {
            return Client.getInstance().getAllUsers();
        }
    
        public string RegisterUser(string username, string password)
        {
            return Client.getInstance().RegisterUser(username,password);
        }

        public List<User> searchUsers(User searchUser)
        {
            return Client.getInstance().searchUsers(searchUser);
        }

        public void logout()
        {
            Client.getInstance().logout();
        }

        public void editInfo(string username, string password,string firstname,string lastname, string hobbies,  string sex, string hometown, string description, string major, int age,DateTime birthday)
        {
            Client.getInstance().editInfo(username, password, firstname, lastname, hobbies, sex, hometown, description, major, age,birthday);
        }


        public string getcurrentName()
        {

            return "ahahah";
            // return Client.getInstance().currentName;
        }
        
        public void setcurrentName(string username)
        {
            Client.getInstance().currentName = username;
        }
    }
    
    
    
}