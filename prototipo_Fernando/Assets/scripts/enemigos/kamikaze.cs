using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class kamikaze : MonoBehaviour
{
    public float radius;
    public float force;
    public float danno;
    public float lookRadius = 10f;
    public gameManager mng;
    public enemyManager enemy;
    public GameObject explosion;

    Transform target;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        target = playerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
       
        if(distance <= lookRadius)
        {
            agent.SetDestination(target.position) ;
        }
        
    }
   
    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            
            mng.vida -= danno;
            explode();
        }
        
       
    }
    public void explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }

        enemy.vida = 0;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
