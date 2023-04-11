using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //  Movement Components
    private CharacterController controller;
    private Animator animator;

    private float moveSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        //  Get movement components
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //  Runs the function that handles all movement
        Move();
    }

    public void Move()
    {
        //  Get the horizontal and vertical inputs as a number
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        //  Direction in a normalised vector
        Vector3 dir = new Vector3(horizontal, 0f, vertical).normalized;

        Vector3 velocity = moveSpeed * Time.deltaTime * dir;

        //  Check if there is movement
        if (dir.magnitude >= 0.1f)
        {
            //  Look toward that direction
            transform.rotation = Quaternion.LookRotation(dir);

            //  Move
            controller.Move(velocity);
        }
    }
}
