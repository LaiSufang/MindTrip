using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{

    [SerializeField] Transform playerTransform;
    [SerializeField] float speed = 5f;

    // create a reference to the moving object
    [SerializeField] GameObject movingObject;
    [SerializeField] GameObject movingObject1;
    [SerializeField] GameObject movingObject2;
    [SerializeField] GameObject movingObject3;
    [SerializeField] GameObject movingObject4;
    [SerializeField] GameObject movingObject5;
    [SerializeField] GameObject movingObject6;
  

    Vector3 playerPosition;

    //private void Awake()
    //{
    //    gameObject.SetActive(true);
    //}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    //    playerPosition = playerTransform.transform.position;
    //}

    //Update is called once per frame
    //void Update()
    //{
    //    playerPosition = playerTransform.transform.position;

    //}
    private void OnTriggerEnter(Collider other)
    {
        playerPosition = playerTransform.transform.position;
        if (other.CompareTag("Player"))
        {
            MoveToPlayer();
        }
    }

    private void MoveToPlayer()
    {
        movingObject.transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        movingObject1.transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        movingObject2.transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        movingObject3.transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        movingObject4.transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        movingObject5.transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        movingObject6.transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

}
