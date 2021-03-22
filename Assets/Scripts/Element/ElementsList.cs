using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsList : MonoBehaviour
{

    public List<Element> elementsList;
    public static List<Element> staticElementsList;

    void Awake()
    {
        staticElementsList = elementsList;
    }

    // Update is called once per frame
    void Update()
    {
        staticElementsList = elementsList;
    }
}
