using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultSlot : MonoBehaviour
{

    public GameObject occupiedObj;
    public static GameObject staticResultObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        staticResultObj = occupiedObj;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Element")
            occupiedObj = other.gameObject;
            StartCoroutine("DeleteResult", other.gameObject);
    }

    IEnumerator DeleteResult(GameObject obj)
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("googaoogaokrgoajkorgakrg");
        Destroy(obj);
    }
}
