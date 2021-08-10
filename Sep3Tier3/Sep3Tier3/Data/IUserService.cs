using System.Collections.Generic;
using System.Threading.Tasks;
using Sep3Tier3.Models;

namespace Sep3Tier3.Data
{
    public interface IUserService
    {

        string LoginUser(string username, string password);

        User RegisterUser(User user);

        List<User> searchUsers(SearchUser searchUser);

        List<User> getAllUsers();

        void editInfo(User user);

        void storeMessage(Message chatMessage);

        User getUser(string username);














    }
}