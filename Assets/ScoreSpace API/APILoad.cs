using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class APILoad : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Dictionary<int,string> yeah = new Dictionary<int, string>();
        yeah.Add(100, "health");
        UserClass user = new UserClass("cut da fruits", "bababooey man", yeah);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateGame(string game)
    {
        try
        {
            UnityWebRequest r = UnityWebRequest.Put($"http://galfar.dyndns.org:25577/reggame/?game={game}", game);
        }
        catch (System.Exception)
        {
            Debug.Log("something has gone wrong!");
            throw;
        }
    }

    // string CreateUser(string game, string user, Dictionary<int, string> args)
    // {
    //     UnityWebRequest r = UnityWebRequest.Put($"http://galfar.dyndns.org:25577/register/?game={game}&username={user}&args={args}",JsonUtility.ToJson(user));
    //     return r. ;
    // }
}
