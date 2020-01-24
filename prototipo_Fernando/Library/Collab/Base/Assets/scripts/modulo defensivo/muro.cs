using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muro : MonoBehaviour
{
   
    public GameObject wallPrefab;

    public Transform cañon;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject bala = Instantiate(wallPrefab, cañon.position, cañon.rotation);
           
        }

    }
   
}
