using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teletransporte : MonoBehaviour
{
    public PlayerController player;
    public gameManager mng;
    public GameObject balizaPrefab;
    public Transform plyer;
    GameObject baliza;
    
    bool balizaActiva = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (mng.combustible >= 40)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                if (balizaActiva == false)
                {
                    mng.combustible -= 40;
                     baliza = Instantiate(balizaPrefab, plyer.position, plyer.rotation);

                    balizaActiva = true;
                }
                else
                {
                    plyer.position = baliza.transform.position;
                    balizaActiva = false;
                    Destroy(baliza);
 
                }

            }


        }



    }
}
