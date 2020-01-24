using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaExplosiva : MonoBehaviour
{
    public float speed = 4f;
    public float timeToExplode = 2;
    public float radius;
    public float force;
    public int danno;
    public enemyManager enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed);
        Invoke("explode", timeToExplode);
    }
     public void explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach(Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider collision)
    {
        explode();
        if (collision.gameObject.tag == "enemigo")
        {
            
            enemy = collision.gameObject.GetComponent<enemyManager>();
            enemy.vida -= danno;

        }
        Destroy(this.gameObject);

        if (collision.gameObject.tag == "pared")
        {
            Destroy(collision.gameObject);
            Debug.Log("pipo");
        }
        Destroy(this.gameObject);
    }
}
