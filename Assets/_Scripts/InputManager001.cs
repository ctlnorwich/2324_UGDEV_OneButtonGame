using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


// This dceals with input
public class InputManager001 : MonoBehaviour
{
    public float myTimer = 0f;

    // Anything below this duration is a tap, anything above a hold.
    public float holdTime;

    public bool hasBeenHeld = false;

    public Material matA;
    public Material matB;

    public float duration = 2.0f;
    float lerpAmount;

    MovementManager movementManager;
    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        movementManager = GetComponent<MovementManager>();
        meshRenderer = GetComponent<MeshRenderer>();
    }
   
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("space"))
        {
            myTimer += Time.deltaTime;

            if (myTimer > holdTime && hasBeenHeld == false)
            {
                InputWasHeld();
                hasBeenHeld = true;
            }

            lerpAmount = Mathf.PingPong(myTimer, duration) / duration;
            meshRenderer.material.Lerp(matA, matB, lerpAmount);
            
        }

        if (Input.GetKeyUp("space"))
        {
            if (myTimer <= holdTime)
            {
                InputWasTapped();
            } 
            myTimer = 0;
            hasBeenHeld = false;
            meshRenderer.material = matA;
            movementManager.Jump(lerpAmount);
        }


    }

    void InputWasHeld()
    {
        Debug.Log("HELD");
        meshRenderer.material = matA;
    }

    void InputWasTapped()
    {
        Debug.Log("TAPPED");
        meshRenderer.material = matB;

    }
}
