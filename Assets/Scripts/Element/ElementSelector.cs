using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementSelector : MonoBehaviour
{

    public Combiner combiner;
    public Slot combinerSlot1;
    public Slot combinerSlot2;
    public ResultSlot result;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn(GameObject spawnObject)
    {
        if(ElementsList.staticElementsList.Contains(spawnObject.GetComponent<Element>()))
        {
            if(!combinerSlot1.occupied && combinerSlot2.occupied)
            {
                InstantiateSpawnObject(spawnObject, combinerSlot1.transform);
            }
            else if(!combinerSlot2.occupied && combinerSlot1.occupied)
            {
                InstantiateSpawnObject(spawnObject, combinerSlot2.transform);
            }
            else if(!combinerSlot1.occupied && !combinerSlot2.occupied)
            {
                InstantiateSpawnObject(spawnObject, combinerSlot1.transform);
            }

            if(Combiner.presentElements.Count > 2)
            {
                Combiner.ClearList();
            }
        }
    }

    void InstantiateSpawnObject(GameObject spawnObject, Transform target)
    {
        var obj = Instantiate(spawnObject, target.position, Quaternion.identity);  
        obj.transform.SetParent(target);
    }
}
