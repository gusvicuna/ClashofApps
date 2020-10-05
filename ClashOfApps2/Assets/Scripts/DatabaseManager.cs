using Proyecto26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public void PostFriendRequestToDatabase(FriendRequest fr)
    {
        RestClient.Post("https://clashofapps-1b287.firebaseio.com/.json", fr);
    }
}
