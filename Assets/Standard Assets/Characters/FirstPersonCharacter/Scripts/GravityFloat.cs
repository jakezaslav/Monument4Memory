using UnityEngine;
using System.Collections;

// The velocity along the y axis is 10 units per second.  If the GameObject starts at (0,0,0) then
// it will reach (0,100,0) units after 10 seconds.

public class GravityFloat : MonoBehaviour
{
    public Rigidbody rb;

    private float time = 0.0f;
    private bool isMoving = false;
    private bool isJumpPressed = false;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Input.GetKey("f"))
        {
            // the cube is going to move upwards in 10 units per second
            rb.velocity = new Vector3(0, 10, 0);
            Debug.Log("jump");
        }
    }
}