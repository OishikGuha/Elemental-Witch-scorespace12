using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{

    public string id;
    public bool unlocked = false;

    Camera cam;
    ElementManager manager;
    
    ElementsList list;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        manager = FindObjectOfType<ElementManager>();
        list = FindObjectOfType<ElementsList>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        
    }
}
