using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combiner : MonoBehaviour
{

    public List<Element> presentElementsDisplay;
    public ElementManager manager;
    public static List<Element> presentElements = new List<Element>();

    public Transform resultTransform;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        presentElementsDisplay = presentElements;

        if(presentElements.Count == 2)
        {
            foreach(ElementCombination elementCombination  in manager.elementCombinations)
            {
                try
                {
                    if(elementCombination.element1.GetComponent<Element>().id == presentElements[0].id && elementCombination.element2.GetComponent<Element>().id == presentElements[1].id)
                    {
                        SpawnResult(elementCombination.result);
                        FindObjectOfType<ElementManager>().FindAndUnlockElement(elementCombination.result);
                        ClearList();
                        ClearList();
                    }
                    else if(elementCombination.element1.GetComponent<Element>().id == presentElements[1].id && elementCombination.element2.GetComponent<Element>().id == presentElements[0].id)
                    {
                        SpawnResult(elementCombination.result);
                        FindObjectOfType<ElementManager>().FindAndUnlockElement(elementCombination.result);
                        ClearList();
                        ClearList();
                    }
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    
                }
            }
        }
    }

    public static void ClearList()
    {

        if(presentElements.Count == 0)
        {
            Debug.Log("Cannot clear!");
        }
        else
        {
            for(int i = 0; i < 1; i++)
            {
                Destroy(presentElements[i].gameObject);
                presentElements.RemoveAt(i);
                Debug.Log(i);
            }
        }
    }

    public void SpawnResult(GameObject resultObj)
    {
        if(ElementsList.staticElementsList.Contains(resultObj.GetComponent<Element>()))
        {
            var obj = Instantiate(resultObj, resultTransform.position, Quaternion.identity);
            obj.transform.SetParent(resultTransform);
        }
    }
}
