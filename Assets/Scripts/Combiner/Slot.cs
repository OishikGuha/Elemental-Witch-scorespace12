using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{

    public bool occupied = false;
    public List<GameObject> occupingObj = new List<GameObject>(); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < occupingObj.Count; i++)
        {
            if(occupingObj[i]==null)
            {
                occupingObj.RemoveAt(i);
                occupied = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Element")
        {
            occupied = true;    
            occupingObj.Add(other.gameObject);
            Combiner.presentElements.Add(other.gameObject.GetComponent<Element>());
        }
    }
}
