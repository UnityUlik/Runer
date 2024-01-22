using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Removing : MonoBehaviour
{
    public void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "RemoveCars")
        {
            Destroy(other.gameObject);
        }
    }
}
