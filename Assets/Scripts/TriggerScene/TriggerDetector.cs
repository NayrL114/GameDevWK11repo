using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.tag == "Red")
        {
            Debug.Log(otherObj.name);
        }
    }

    private void OnTriggerExit(Collider otherObj)
    {
        if (otherObj.tag == "Blue")
        {
            Debug.Log(otherObj.name);
        }
    }
}
