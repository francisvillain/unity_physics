using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float force = 5f;
    public float speed = 5f;
    public float torque = 10f;
    public Rigidbody rb;
    public bool grounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(new Vector3(0,force,0), ForceMode.Impulse);
            grounded = false;
        }

        handlePlayerMovement();
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Ground")
            grounded = true;
    }

    private void handlePlayerMovement()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector3.right;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector3.left;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = -Vector3.forward;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector3.forward;
        }

        rb.AddTorque(direction*torque);
    }

}
