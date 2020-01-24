using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchDefense : MonoBehaviour
{
    public int SeleccionDefensa = 0;
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
