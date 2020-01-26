using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resbaladizo : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            player.GetComponent<PlayerController>().speed = 14;
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            player.GetComponent<PlayerController>().speed = 6;
        }

    }
}
