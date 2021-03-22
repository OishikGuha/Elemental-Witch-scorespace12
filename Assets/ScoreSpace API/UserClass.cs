using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserClass
{
    public string game;
    public string user;
    public Dictionary<int, string> args;

    public UserClass(string game,string user, Dictionary<int, string> args)
    {
        this.game = game;
        this.user = user;
        this.args = args;
    }
}
