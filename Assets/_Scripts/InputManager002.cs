using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    float myTimer = 0f;
    public float rotateSpeed = 0.001f;

    public float tapHoldThreshold = 1f;

    public Color myCubeColor;

    Renderer rend;

    float myColorTimer = 0f;

    Color startColor;
   
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        /*
         
         This is for a multi line comment
         */

        // The 3 lines below all mean the same

       
        GetComponent<Transform>().Rotate(0f, rotateSpeed * Time.deltaTime, 0f);

        // This is for input
        if (Input.GetKey("space"))
        {
            myTimer += Time.deltaTime;
        }

        if (Input.GetKeyDown("space")){
            KeyHasBeenPressed();
        }

        if (Input.GetKeyUp("space"))
        {
            if (myTimer >= tapHoldThreshold)
            {
                Hold();
            }
            else
            {
                Tap();
            }
            myTimer = 0;
        }

        if (myColorTimer >= 0f)
        {
            myColorTimer -= Time.deltaTime;
            
        }
        else
        {
            rend.material.color = startColor;
        }

    }

    void Hold()
    {
        Debug.Log("KEY Has been held");
        rend.material.color = Color.cyan;
        myColorTimer = 2f;
    }

    void Tap()
    {
        Debug.Log("KEY has been tapped");
        rend.material.color = Color.yellow;
        myColorTimer = 2f;

    }

    void KeyHasBeenPressed()
    {
        Debug.Log("KEY Has been pressed");
        rend.material.color = Color.magenta;
        myColorTimer = 2f;

    }

}
