using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electricidad : MonoBehaviour
{
    PlayerController player;
    public gameManager mng;
    
    public float danno;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mng = collision.gameObject.GetComponent<gameManager>();

            if (mng.escudo > 0)
            {
                mng.escudo -= danno;
                collision.gameObject.GetComponent<PlayerController>().speed = 3;
                Invoke("ralentizar", 4f);
            }
            else
            {
                mng.vida -= danno;
                collision.gameObject.GetComponent<PlayerController>().speed = 3;
                Invoke("ralentizar", 4f);
            }
            Destroy(this.gameObject);
        }
    }
    public void ralentizar()
    {
        player.speed = 6;
    }
}
