using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb; 

    public float forwardForce = 10f;
    public float sidewaysForce = 1600f;

    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = false;
        rb.AddForce(0, 100, 600);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // WASD control
        if(Input.GetKey("w")) {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);
        }
        if(Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("s")) {
            rb.AddForce(0, 0, -2 * forwardForce * Time.deltaTime);
        }

        // jump
        if(Input.GetKey("space")){
            rb.AddForce(0, 3 * forwardForce * Time.deltaTime, 0);
        }
    }
}
