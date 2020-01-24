using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    public int SeleccionArma= 0;
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        int PreviousSelectedWeapon = SeleccionArma;

                  
        
        if (Input.GetKeyDown("q"))
        {
            if (SeleccionArma <= 0)
            {
                SeleccionArma = transform.childCount -1;
            }
            else
            {
                SeleccionArma--;
            }
        }

        if (PreviousSelectedWeapon != SeleccionArma)
        {
            SelectWeapon();
        }
    }
    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == SeleccionArma)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
