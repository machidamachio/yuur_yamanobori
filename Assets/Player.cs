using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float moveSpeed = 5.0f;

    public Rigidbody rb;
    bool grounded;
    float jumpPower = 500;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += moveSpeed * transform.forward * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= moveSpeed * transform.forward * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += moveSpeed * transform.right * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= moveSpeed * transform.right * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0,0.5f,0));
        }
                
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0,-0.5f,0));
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded == true)
            {
                rb.AddForce(Vector3.up * jumpPower);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
}