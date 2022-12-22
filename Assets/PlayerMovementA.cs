using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementA : MonoBehaviour
{
    public Rigidbody rb; public Transform camera; public Vector3 cmos; 
    public float speed = 1000f; public float moveSpeed = 100f; public bool jcool = false;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed*Time.deltaTime);
        rb.AddForce(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        camera.position = transform.position + cmos;
    }

    void Update() { if (Input.GetButtonDown("Jump") && jcool == false) { rb.AddForce(0, 250, 0); } }
    public void OnCollisionEnter(Collision collision) { if (collision.collider.name == "Patoma") { jcool = false; } }

    

}


    