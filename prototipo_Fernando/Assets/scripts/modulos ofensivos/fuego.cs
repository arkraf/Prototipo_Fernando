using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuego : MonoBehaviour
{
    public enemyManager enemy;
    public float danno = 0.5f;
    bool quemar = false;

    // Start is called before the first frame update
    void Start()
    {

        
    }
    // Update is called once per frame
    void Update()
    {

        if (quemar == true)
        {
            Invoke("quemado", 1f);
        }
        
    }
    private void OnTriggerStay(Collider collision)
    {
        
        if (collision.gameObject.tag == "enemigo")
        {
            enemy = collision.gameObject.GetComponent<enemyManager>();
            quemar = true;
            enemy.vida -= danno * Time.deltaTime;
              
            Invoke("apagar", 5f);
            

        }
        
    }
    public void quemado()
    {
        enemy.vida -= 3;
    }
    public void apagar()
    {
        quemar = false;
    }
}
