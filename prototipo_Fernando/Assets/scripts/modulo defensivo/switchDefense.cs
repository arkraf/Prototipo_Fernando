using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchDefense : MonoBehaviour
{
    public int SeleccionDefensa = 0;

    public GameObject escudo;
    public GameObject muro;
    public GameObject areaElectrica;
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        int PreviousSelectedWeapon = SeleccionDefensa;

        
        if (Input.GetKeyDown("f"))
        {
            if (SeleccionDefensa <= 0)
            {
                SeleccionDefensa = transform.childCount - 1;
            }
            else
            {
                SeleccionDefensa--;
            }
        }

        if (PreviousSelectedWeapon != SeleccionDefensa)
        {
            SelectWeapon();
        }


        if (SeleccionDefensa == 0)
        {
            escudo.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
            muro.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            areaElectrica.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }
        if (SeleccionDefensa == 1)
        {
            escudo.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            muro.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            areaElectrica.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
        }
        if (SeleccionDefensa == 2)
        {
            escudo.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            muro.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
            areaElectrica.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }
    }
    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == SeleccionDefensa)
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
