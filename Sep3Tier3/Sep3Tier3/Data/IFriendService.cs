using System.Collections.Generic;
using Sep3Tier3.Models;

namespace Sep3Tier3.Data
{
    public interface IFriendService
    {
        List<Friend> getAllFriends();
        List<Friend> getFriends(string username1);
        Friend delete(Friend friend);

        Friend sendFriendRequest(Friend friend);

        List<Friend> getFriendRequest(string username1);

        Friend agree(Friend friend);

    }
}