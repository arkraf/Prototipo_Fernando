using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchMovility : MonoBehaviour
{
    public int SeleccionMovilidad = 0;

    public GameObject turbo;
    public GameObject teleport;
    public GameObject gancho;
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

        if (SeleccionMovilidad == 0)
        {
            turbo.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
            teleport.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            gancho.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }
        if (SeleccionMovilidad == 1)
        {
            turbo.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            teleport.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            gancho.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
        }
        if (SeleccionMovilidad == 2)
        {
            turbo.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            teleport.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
            gancho.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
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
