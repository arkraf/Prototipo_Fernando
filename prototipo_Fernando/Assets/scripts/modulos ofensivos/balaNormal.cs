using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaNormal : MonoBehaviour
{
    public float speed = 4f;
    public int danno;
    public float danoJ =0.5f ;
    public float timeToExplode = 2;
     PlayerController player;
     enemyManager enemy;
    public gameManager mng;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward *speed);
        Invoke("explode", timeToExplode);
    }
    public void explode()
    {
        Destroy(this.gameObject);
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            mng = collision.gameObject.GetComponent<gameManager>();

            if(mng.escudo > 0)
            {
                mng.escudo -= danoJ;
            }
            else
            {
                mng.vida -= danoJ;
            }
            Destroy(this.gameObject);
        }
      

        if ((collision.gameObject.tag == "enemigo") ||(collision.gameObject.tag == "enemigoArmado"))
        {
            enemy = collision.gameObject.GetComponent<enemyManager>();
            enemy.vida -= danno;
            Destroy(this.gameObject);
        }

        if (collision.tag == "elMuro")
        {
            Debug.Log("pipo");
            Destroy(this.gameObject);
            
        }


    }
   
}
