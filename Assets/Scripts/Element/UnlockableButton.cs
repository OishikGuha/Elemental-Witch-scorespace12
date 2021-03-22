using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockableButton : MonoBehaviour
{

    public GameObject unlockableObj;

    Button button;
    UnlockedList unlockList;

    // Start is called before the first frame update
    void Start()
    {
        unlockList = FindObjectOfType<UnlockedList>();
        button = GetComponentInChildren<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in unlockList.list)
        {

            Element itemElement = item.element.GetComponent<Element>();
            Element thisElement = unlockableObj.GetComponent<Element>();  

            if(itemElement.id == thisElement.id)
            {
                if(!item.unlocked)
                {
                    button.GetComponent<Image>().color = new Color(0f,0f,0f,1f);
                    button.interactable = false;
                }
                else if(item.unlocked)
                {
                    button.GetComponent<Image>().color = new Color(1f,1f,1f,1f);    
                    button.interactable = true; 
                }
            }
        }
    }
}
