using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaSpawner : MonoBehaviour
{

    public GameObject balaPrefab;

    public Transform cañon;

    public float timeToSpawn = 2;
       
    // Start is called before the first frame update
    void Start()
    {
        //Invoke permite ejecutar una funcion al cabo de un tiempo

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shoot()
    {
        GameObject bala = Instantiate(balaPrefab, cañon.position, cañon.rotation);

        //para acceder a un componente de un objeto, usamos GetComponent
        //Recuerdo comprobar siempre si el retorno no es nulo,antes de usar la variable

        balaNormal script = bala.GetComponent<balaNormal>();
        
        if(script != null)
        {
            script.speed = 0.5f;
        }

       



    }

    private void OnTriggerStay(Collider other)
    {
        
            if (other.gameObject.tag == "Player")
            {
                if (timeToSpawn == 2)
                {
                    shoot();
                    
                }

                timeToSpawn -= 1 *Time.deltaTime;

                if (timeToSpawn <= 0)
                {
                timeToSpawn = 2;
                }
                    
                
            }     
        
       


    }

    
}
