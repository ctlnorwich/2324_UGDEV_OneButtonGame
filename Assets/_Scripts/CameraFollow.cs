using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform objectToFollow;
    public float cameraHeight;

    // this locks the object this script is attached to to the o0bject to follow
    // ToDo turn this into a Vector3 offset.
    void Update()
    {
        transform.position = new Vector3(objectToFollow.position.x, cameraHeight, objectToFollow.position.z - 10f);
    }
}
