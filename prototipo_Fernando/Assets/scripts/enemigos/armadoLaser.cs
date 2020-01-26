using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class armadoLaser : MonoBehaviour
{
    public float lookRadius = 10f;

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

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
        }
        if (distance <= agent.stoppingDistance)
        {

        }
        if( agent.speed == 0)
        {
            Invoke("reactivar", 5f);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
    public void reactivar()
    {
        agent.speed = 8;
    }
}
