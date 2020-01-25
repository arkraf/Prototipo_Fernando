using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recogida : MonoBehaviour
{
    public GameObject player;
    public gameManager mng;
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
            if(mng.vida < mng.vidaMax)
            {
                mng.vida += ((mng.vidaMax *20 ) / 100);
                Destroy(this.gameObject);
            }
           
        }

    }
}
