using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AreaElectrica : MonoBehaviour
{
    public gameManager mng;
    public GameObject electricidad;
    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mng.energia >= 30)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Instantiate(electricidad, transform.position, transform.rotation);
                mng.energia -= 30;
            }
        }
        
    }
    private void OnTriggerStay(Collider collision)
    {

        if (collision.gameObject.tag == "enemigo")
        {
            collision.GetComponent<NavMeshAgent>().speed = 0;

        }


    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    
}

