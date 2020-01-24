using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosivos : MonoBehaviour
{
    public GameObject explosivoPrefab;

    public Transform cañon;

    public float timeToSpawn = 4;
    public float delay = 0f;
    public gameManager mng;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        if (delay == 0)
        {
             if (mng.AmmoeExpl > 0)
             {
            
                 if (Input.GetMouseButtonDown(0))
                 {
                    shoot();
                    mng.AmmoeExpl--;
                    delay = 2f;
                
                 }

             }
                 
        }
        else
        {
            delay -= 1 * Time.deltaTime;
            if(delay < 0)
            {
                delay = 0;
            }
            
        }
        
    }

    public void shoot()
    {
        GameObject bala = Instantiate(explosivoPrefab, cañon.position, cañon.rotation);



        balaNormal script = bala.GetComponent<balaNormal>();
        if (script != null)
        {
            script.speed = 0.5f;
        }




    }
}
