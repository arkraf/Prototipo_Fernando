using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torretaManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject.Find("cabeza").GetComponent<LookAt>().enabled = false;
                GameObject.Find("cañon").GetComponent<balaSpawner>().enabled = false;
            }
           
        }
        

    }
}
