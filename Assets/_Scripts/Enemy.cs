using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // This checks if this object collides with ANYTHING that has a rigdbody
    void OnCollisionEnter(Collision collision)
    {
        // this prints when the other object has a rigidbody
        // same as
        // if(collision.rigidbody == true)
        if (collision.rigidbody)
        {
            Debug.Log("GAMEOVER");
        }
    }
}
