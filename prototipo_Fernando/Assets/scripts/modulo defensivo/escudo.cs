using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class escudo : MonoBehaviour
{
    public gameManager mng;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((mng.energia >= 30) && (mng.escudo <=0))
        {
            if (Input.GetMouseButtonDown(1))
            {
                mng.escudo = mng.escudoMax;
                mng.energia -= 30;
                Invoke("cd", 5f);
            }
        }
        
    }
    void cd()
    {
        mng.escudo = 0;
    }
}
