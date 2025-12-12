using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropByTrigger : MonoBehaviour
{
    // create a reference to the dropping object
    [SerializeField] GameObject dropObject;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dropObject.GetComponent<Rigidbody>().useGravity = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dropObject.GetComponent<Rigidbody>().useGravity = true;
            
            // destroy this trigger entry object after activation
            Destroy(gameObject);
        }
    }

 
}
