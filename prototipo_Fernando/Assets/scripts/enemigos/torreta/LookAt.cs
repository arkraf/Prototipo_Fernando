using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    public float range = 10f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            float dist = Vector3.Distance(target.position, transform.position);
            if(dist <= range)
            {
                transform.LookAt(target);
                
            }
            else
            {
                resetRotation();
            }
            
        }
        else
        {
            resetRotation();
        }
        
    }
     void resetRotation()
    {
        Quaternion lerpedRotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Vector3.zero), 0.05f);

        transform.rotation = lerpedRotation;
    }
}
