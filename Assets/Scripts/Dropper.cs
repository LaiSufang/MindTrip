using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropTimer = 3f;

    // Cashe references to components
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;   

        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTimer)
        {
            // Make the object visible
            myMeshRenderer.enabled = true;

            // Make the object fall by enabling gravity
            myRigidbody.useGravity = true;
            Debug.Log("Watch out below!");

            // Disable this script so it doesn't keep running
            this.enabled = false;
        }
    }
}
