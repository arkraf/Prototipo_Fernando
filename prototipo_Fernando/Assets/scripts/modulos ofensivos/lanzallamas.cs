using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzallamas : MonoBehaviour
{
    public GameObject fuegoPrefab;

    public Transform cañon;
   
    public float timeToSpawn = 4;
    public gameManager mng;

    // Start is called before the first frame update
    void Start()
    {
        
        fuegoPrefab.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(mng.AmmoFire > 0)
        {
            if (Input.GetMouseButton(0))
            {
                fuegoPrefab.SetActive(true);
                mng.AmmoFire--;
            }
            else
            {
                fuegoPrefab.SetActive(false);
            }
        }
        else
        {
            fuegoPrefab.SetActive(false);
        }



    }

   
}
