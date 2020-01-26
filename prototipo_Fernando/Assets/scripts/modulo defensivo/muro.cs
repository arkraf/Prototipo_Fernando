using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muro : MonoBehaviour
{
    public float duration = 3f;
    public PlayerController player;
    public GameObject wallPrefab;
    public gameManager mng;

    public Transform cañon;
    void Start()
    {

        wallPrefab.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
        if (mng.energia >= 30) 
        {
            if (Input.GetMouseButtonDown(1))
            {
                wallPrefab.SetActive(true);

                player.speed = 0f;
                Invoke("wall", duration);
            }
        }

    }
    public void wall()
    {
        player.speed = 6f;
        wallPrefab.SetActive(false);
    }

}
