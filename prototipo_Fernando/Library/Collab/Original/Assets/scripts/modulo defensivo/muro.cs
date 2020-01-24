using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muro : MonoBehaviour
{
   
    public GameObject wallPrefab;
    public PlayerController player;
    public Transform cañon;
    void Start()
    {

        wallPrefab.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        {                      
                if (Input.GetMouseButtonDown(1))
                {
                    wallPrefab.SetActive(true);
                    player.speed = 0;

                    Invoke("desactivar",4);
                }
               
                                   
        }      
    }
   void desactivar()
    {
        wallPrefab.SetActive(false);
        player.speed = 6;
    }
}
