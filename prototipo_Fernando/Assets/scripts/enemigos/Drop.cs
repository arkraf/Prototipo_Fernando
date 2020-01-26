using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public int dropeo = 1;
    public gameManager mng;
    public Random rnd = new Random();
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        mng = GameObject.Find("Player").GetComponent<gameManager>();

        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        dropeo = (UnityEngine.Random.Range(1,6));
    }
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == player)
        {
            switch (dropeo)
            {
                case 1:
                    mng.energia += 20;

                    break;
                case 2:
                    mng.combustible += 20;
                    break;
                case 3:
                    mng.AmmoAuto += 20;
                    break;
                case 4:
                    mng.AmmoeExpl += 5;
                    break;
                case 5:
                    mng.AmmoFire += 100;
                    break;

            }
            Destroy(this.gameObject);
        }

    }
}

