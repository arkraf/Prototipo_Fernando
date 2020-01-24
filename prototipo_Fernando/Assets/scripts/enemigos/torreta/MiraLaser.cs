using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(LineRenderer))]
public class MiraLaser : MonoBehaviour
{
    LineRenderer Linea;

    public LayerMask queEsSolido;
    
    // Start is called before the first frame update
    void Start()
    {       
        Linea = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Linea.SetPosition(0, transform.position);

        if (Physics.Raycast(transform.position, transform.forward, out hit, 100,queEsSolido))
        {
            Linea.SetPosition(1, hit.point);
            
            
        }
        else
        {
            Linea.SetPosition(1, transform.transform.position+ transform.forward *1000);
        }
    }
}
