﻿using System;
using System.Collections.Generic;
using Tier1.Model;

namespace Tier1.Data
{
    public interface IUserService
    {

        void Connect();
        User getUserInfo(string username);
    
        
        User ValidateUser(string username, string password);

       string RegisterUser(string username, string password);


        void logout();

        List<User> getAllUsers();
        List<User> searchUsers(User searchUser);
        
        void editInfo(string username, string password, string firstname, string lastname, string hobbies,
            string sex, string hometown, string description, string major, int age, DateTime birthday);


        string getcurrentName();

         void setcurrentName(string username);
    }
}

