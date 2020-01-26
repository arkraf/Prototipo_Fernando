using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoArmado : MonoBehaviour
{
    public GameObject punto1, punto2;
    public bool direccion;
    public Transform punto;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
        if (direccion) punto = punto2.transform;
        else punto = punto1.transform;
        punto1.transform.position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (direccion) punto = punto2.transform;
        else punto = punto1.transform;


        if (direccion)
        {
            transform.position = Vector3.MoveTowards(transform.position, punto2.transform.position, speed * Time.deltaTime);
        }
            
        if (direccion == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, punto1.transform.position, speed * Time.deltaTime);
        }

        if (speed == 0)
        {
            Invoke("moverse", 5f);
        }
    }
           
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Punto 1")
        {
            
            direccion = true;
            punto = punto2.transform;
            
        }
        if (other.tag == "Punto 2")
        {
            direccion = false;
            punto = punto1.transform;
            

        }
       
    }
    void moverse()
    {
        speed = 5;
        gameObject.GetComponentInChildren<balaSpawner>().enabled = true;
        gameObject.GetComponentInChildren<BoxCollider>().enabled = true;
    }
   
}
