using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SmoothPosition : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 6f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * smoothTime);
            
    }
}
