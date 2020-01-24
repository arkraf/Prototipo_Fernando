using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaAutomatica : MonoBehaviour
{

    public GameObject balaPrefab;
    
    public Transform cañon;

    public float timeToSpawn = 2;
    public gameManager mng;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        if (mng.AmmoAuto > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                shoot();
                mng.AmmoAuto--;
            }
            
        }
        
    }

    public void shoot()
    {
        GameObject bala = Instantiate(balaPrefab, cañon.position, cañon.rotation);
        


        balaNormal script = bala.GetComponent<balaNormal>();
        if (script != null)
        {
            script.speed = 0.5f;
        }




    }
}