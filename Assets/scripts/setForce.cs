using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setForce : MonoBehaviour
{
    [SerializeField]
    public float Speed;
    [SerializeField]
    KeyCode keyJump;

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
      
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was released.");
            GetComponent<Rigidbody>().AddForce(Vector3.up*1000);
        }
        
    }
}
