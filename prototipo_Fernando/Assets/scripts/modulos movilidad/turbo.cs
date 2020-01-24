using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turbo : MonoBehaviour
{
    public float duration = 2f;
    public PlayerController player;
    public gameManager mng;

    // Update is called once per frame
    void Update()
    {
        if (mng.combustible >= 20)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                mng.combustible -= 20;
                player.speed = 12f;
                Invoke("endTurbo", duration);
            }
        }
        
        
    }
    public void endTurbo()
    {
       player.speed = 6f;
    }
}
