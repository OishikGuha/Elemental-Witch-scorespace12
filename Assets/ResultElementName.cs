using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultElementName : MonoBehaviour
{

    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        if(ResultSlot.staticResultObj != null)
        {
            if(ResultSlot.staticResultObj.name.Contains("(Clone)"))
            {
                string resultName = ResultSlot.staticResultObj.name;
                text.text = resultName.Substring(0,resultName.Length-7);
            }
        }
    }
}
