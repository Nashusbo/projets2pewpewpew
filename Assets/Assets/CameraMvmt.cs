using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMvmt : MonoBehaviour
{
    public Rigidbody playerRb=null;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = playerRb.position;
    }
}
