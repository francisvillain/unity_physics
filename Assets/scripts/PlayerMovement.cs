using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    public Rigidbody rb;
    public bool grounded = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        float vertical = Input.GetAxis("Vertical")*Time.deltaTime*speed;
        
        transform.Translate(horizontal,0,vertical);

        if(Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(new Vector3(0,5,0), ForceMode.Impulse);
            grounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Ground")
            grounded = true;
    }

}
