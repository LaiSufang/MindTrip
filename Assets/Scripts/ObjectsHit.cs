using UnityEngine;

public class ObjectsHit : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        // If collide with the player, change color to green, and change the object tag to "Hit"
        if (collision.gameObject.CompareTag("Player"))
        { 
            GetComponent<MeshRenderer>().material.color = Color.green;
            //gameObject.tag = "Hit"; 
        }
    }
}
