using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 2000f;
    public float moveSpeed = 600;
    public float jumpSpeed = 1000;
    /// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-moveSpeed, 0, 0);
        }

        else if (Input.GetKey("d"))
        {
            rb.AddForce(moveSpeed, 0, 0);
        }
        else if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(0, jumpSpeed, 0);
        }
    }
}
