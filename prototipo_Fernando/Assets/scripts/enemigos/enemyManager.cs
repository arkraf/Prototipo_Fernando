using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    public float vida = 100;
    public gameManager mng;
    public GameObject drop;
     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vida <= 0)
        {
            mng.exp += 20;
            Instantiate(drop, transform.position, transform.rotation);
            Destroy(this.gameObject);      
            
        }
    }
    

    
    
    
   
}
