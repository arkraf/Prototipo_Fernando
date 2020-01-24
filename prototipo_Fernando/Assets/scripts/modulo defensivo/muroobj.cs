using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muroobj : MonoBehaviour
{
    

   

    // Update is called once per frame
    void Update()
    {
        
             
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "bala")
        {
            Destroy(collision.gameObject);
        }
    }

}
