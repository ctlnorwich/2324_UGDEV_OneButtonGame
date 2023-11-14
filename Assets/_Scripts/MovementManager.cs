using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This moves our player
public class MovementManager : MonoBehaviour
{
    Rigidbody rb;
    public float movementSpeed = 5f;
    public float jumpPower = 1000f;
    bool doJump = false;

    float jumpAmount;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
       
        rb.MovePosition(transform.position + transform.forward * Time.deltaTime * movementSpeed);

        
        if (doJump)
        {
            Vector3 jumpForce = new Vector3(0f, jumpAmount * jumpPower, 0f);
            rb.AddForce(jumpForce);
            doJump = false;
        }
    }

    public void Jump(float amount)
    {
        jumpAmount = amount;
        doJump = true;
    }
}
