using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gancho : MonoBehaviour
{
    public GameObject player;
    public GameObject botonInteract;
    public GameObject enganche;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerStay(Collider collision)
    {
        Debug.Log("pipo");
        if (collision.gameObject.tag == "enganche")
        {
            Debug.Log("popiiii");
            botonInteract.SetActive(true);
            enganche = collision.gameObject;
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
          
                player.transform.parent = enganche.transform;

                player.transform.position = enganche.transform.position - new Vector3 (0,2,0);
                player.GetComponent<PlayerController>().gravity = 0;

            }

        }


    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "enganche")
        {
            botonInteract.SetActive(false);
            player.GetComponent<PlayerController>().gravity = 0;
        }

    }
}
