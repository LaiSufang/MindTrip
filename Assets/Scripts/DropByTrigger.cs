using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DropByTrigger : MonoBehaviour
{
    // create a reference to the dropping object
    [SerializeField] GameObject dropObject;
    [SerializeField] GameObject dropObject1;
    [SerializeField] GameObject dropObject2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dropObject.GetComponent<Rigidbody>().useGravity = false;
        dropObject1.GetComponent<Rigidbody>().useGravity = false;
        dropObject2.GetComponent<Rigidbody>().useGravity = false;

        dropObject.GetComponent<MeshRenderer>().enabled = false;
        dropObject1.GetComponent<MeshRenderer>().enabled = false;
        dropObject2.GetComponent<MeshRenderer>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dropObject.GetComponent<MeshRenderer>().enabled = true;
            dropObject1.GetComponent<MeshRenderer>().enabled = true;
            dropObject2.GetComponent<MeshRenderer>().enabled = true;

            dropObject.GetComponent<Rigidbody>().useGravity = true;
            dropObject1.GetComponent<Rigidbody>().useGravity = true;
            dropObject2.GetComponent<Rigidbody>().useGravity = true;


            // destroy this trigger entry object after activation
            Destroy(gameObject);
        }
    }

 
}
