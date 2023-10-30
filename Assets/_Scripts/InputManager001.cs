using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager001 : MonoBehaviour
{
    //int myInt = 0;
    float myTimer = 0f;
    //public float spinSpeed = 0.1f;

    // Anything below this duration is a tap, anything above a hold.
    public float holdTime;

    public bool hasBeenHeld = false;

    public Material matRed;
    public Material matOther;

    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        //myTimer = Time.deltaTime * spinSpeed;
        //Debug.Log("This is the timer: " + myTimer + " This is deltaTime: " + Time.deltaTime);


        if (Input.GetKey("space"))
        {
            myTimer += Time.deltaTime;

            if (myTimer > holdTime && hasBeenHeld == false)
            {
                InputWasHeld();
                hasBeenHeld = true;
            }
            
        }

        if (Input.GetKeyUp("space"))
        {
            if (myTimer <= holdTime)
            {
                InputWasTapped();
            }
            myTimer = 0;
            hasBeenHeld = false;
        }
    }

    void InputWasHeld()
    {
        Debug.Log("HELD");
        GetComponent<MeshRenderer>().material = matRed;
    }

    void InputWasTapped()
    {
        Debug.Log("TAPPED");
        GetComponent<MeshRenderer>().material = matOther;

    }
}
