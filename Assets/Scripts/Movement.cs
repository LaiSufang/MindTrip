using UnityEngine;

public class Movement : MonoBehaviour
{
    // caching component references
    CharacterController controller;
    Animator animator;   

    [SerializeField] float moveSpeed = 5f;

    private bool facingBack;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        animator = gameObject.GetComponent<Animator>();        

        //facingBack = false;

        // TODO: Rotate the character based on arrow key input
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Rotate(0f, -90f, 0f);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Rotate(0f, 90f, 0f);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal"); // check input manager to see this value
        //float yValue = 0f;
        float zValue = Input.GetAxis("Vertical");
        //transform.Translate(xValue, yValue, zValue);
        Vector3 move = transform.forward * zValue + transform.right * xValue;
        controller.Move(move * Time.deltaTime * moveSpeed);

        // animations
        if (xValue != 0 || zValue != 0)
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {
                // flip character based on vertical movement
                //if (zValue < 0 && !facingBack)
                //{
                //    TurnAround();
                //}
                //else if (zValue > 0 && facingBack)
                //{
                //    TurnAround();
                //}
                // TODO: flip character based on horizontal movement

               
                // set animator parameters
                animator.SetBool("isIdle", false);
                animator.SetBool("isWalking", true);
            }
            else
            {
                animator.SetBool("isWalking", false);
                animator.SetBool("isIdle", true);
            }
        }
    }
    //private void TurnAround()
    //{
    //    facingBack = !facingBack;
    //    Vector3 scaler = transform.localScale;
    //    scaler.z *= -1f;
    //    transform.localScale = scaler;
    //}
    
}
