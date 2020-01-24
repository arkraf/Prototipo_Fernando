using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class mouseGiro : MonoBehaviour
{
    public float speedRot;

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Rotate(0, Input.GetAxis("Mouse X") * speedRot, 0);
    }
}
