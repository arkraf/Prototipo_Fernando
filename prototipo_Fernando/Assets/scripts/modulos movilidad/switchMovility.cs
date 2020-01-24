using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchMovility : MonoBehaviour
{
    public int SeleccionMovilidad = 0;
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        int PreviousSelectedWeapon = SeleccionMovilidad;


        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (SeleccionMovilidad <= 0)
            {
                SeleccionMovilidad = transform.childCount - 1;
            }
            else
            {
                SeleccionMovilidad--;
            }
        }

        if (PreviousSelectedWeapon != SeleccionMovilidad)
        {
            SelectWeapon();
        }
    }
    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == SeleccionMovilidad)
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
