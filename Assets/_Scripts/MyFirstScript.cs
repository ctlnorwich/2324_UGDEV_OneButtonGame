using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public int myFirstInt = 1;
    float myFirstFloat = 0.1f;
    public Vector3 amount = new Vector3(5, 5, 10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            GetComponent<Transform>().Rotate(amount);
        }
    }
}
