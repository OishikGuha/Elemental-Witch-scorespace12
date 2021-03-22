using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedList : MonoBehaviour
{
    public List<UnlockObject> list = new List<UnlockObject>();
    public static List<UnlockObject> staticUnlockList;

    void Start()
    {   
        for(int i = 0; i < ElementsList.staticElementsList.Count; i++)
        {
            list.Add(new UnlockObject());
        }

        for (int i = 0; i < list.Count; i++)
        {
            list[i].element = ElementsList.staticElementsList[i];
        }
    
        staticUnlockList = list;
    }
}
