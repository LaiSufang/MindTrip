using System;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float speed = 5f;

    Vector3 playerPosition;

    //private void Awake()
    //{
    //    gameObject.SetActive(true);
    //}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = playerTransform.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestryWhenReached();
    }

    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    private void DestryWhenReached()
    {
        if (transform.position == playerPosition)
        { 
            Destroy(gameObject); 
        }
    }
}
