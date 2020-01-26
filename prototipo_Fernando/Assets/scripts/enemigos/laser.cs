using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
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
            }
            else
            {
                mng.vida -= danno;
            }
            Destroy(this.gameObject);
        }
    }
}
