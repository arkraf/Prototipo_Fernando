using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    public int SeleccionArma= 0;
    public GameObject ammoAuto;
    public GameObject ammoExplo;
    public GameObject ammoFire;
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

        if(SeleccionArma == 0)
        {
            ammoAuto.transform.localScale =  new Vector3(1.8f,1.8f,1.8f);
            ammoExplo.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            ammoFire.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }
        if (SeleccionArma == 1)
        {
            ammoAuto.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            ammoExplo.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            ammoFire.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
        }
        if (SeleccionArma == 2)
        {
            ammoAuto.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            ammoExplo.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
            ammoFire.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
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
