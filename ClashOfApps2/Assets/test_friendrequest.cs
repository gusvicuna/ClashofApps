using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test_friendrequest : MonoBehaviour
{
    public TMP_InputField FriendUsernameField;
    public DatabaseManager dbm;
    public void SendFriendRequest()
    {
        User player1 = new User("player1", 0);
        FriendRequest fr1 = new FriendRequest(player1, FriendUsernameField.text);
        dbm.PostFriendRequestToDatabase(fr1);
    }

    public void ConsoleLog()
    {
        Debug.Log("Sending friend request");
    }
}
