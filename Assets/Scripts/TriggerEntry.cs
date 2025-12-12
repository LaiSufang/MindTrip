using UnityEngine;

public class TriggerEntry : MonoBehaviour
{
    // create a reference to the fly object
    [SerializeField] GameObject flyObject;
    [SerializeField] GameObject flyObject1;
    [SerializeField] GameObject flyObject2;

    private void Start()
    {
        flyObject.SetActive(false);
        flyObject1.SetActive(false);
        flyObject2.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flyObject.SetActive(true);
            flyObject1.SetActive(true);
            flyObject2.SetActive(true);

            // destroy this trigger entry object after activation
            Destroy(gameObject);
        }
    }
}
