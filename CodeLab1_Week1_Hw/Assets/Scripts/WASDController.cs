using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    private Rigidbody myRB;
    public float forceAmount = 9;
    public float maxVelocity = 200;
    
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //press the W key to send the player object forward
        if (Input.GetKey(KeyCode.W))
        {
            myRB.AddForce(Vector3.forward * forceAmount);
        }
        //press the A key to send the player object to the left
        if (Input.GetKey(KeyCode.A))
        {
            myRB.AddForce(Vector3.left * forceAmount);
        }
        //press the S key to send the player object back
        if (Input.GetKey(KeyCode.S))
        {
            myRB.AddForce(Vector3.back * forceAmount);
        }
        //press the D key to send the player object to the right
        if (Input.GetKey(KeyCode.D))
        {
            myRB.AddForce(Vector3.right * forceAmount);
        }
        //ensures the player will never reach a speed above what is set as the maxVelocity
        if (myRB.velocity.magnitude > maxVelocity)
        {
            Vector3 newVelocity = myRB.velocity.normalized * maxVelocity;
            myRB.velocity = newVelocity;
        }

    }
}
