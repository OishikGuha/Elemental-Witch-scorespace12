using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementManager : MonoBehaviour
{

    public List<ElementCombination> elementCombinations = new List<ElementCombination>();
    ElementsList list;

    // Start is called before the first frame update
    void Start()
    {
        list = FindObjectOfType<ElementsList>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FindAndUnlockElement(GameObject element)
    {
        UnlockedList unlockedList = GetComponent<UnlockedList>();
        foreach(var item in unlockedList.list)
        {
            Element itemElement = item.element.GetComponent<Element>();
            Element objElement = element.GetComponent<Element>();

            if(itemElement.id == objElement.id)
            {
                if(!item.unlocked)
                {
                    Debug.Log(itemElement.name);
                    item.unlocked = true;
                    Score.score++;
                    AudioManager.PlaySFX();
                }
            }
        }
    }
}
