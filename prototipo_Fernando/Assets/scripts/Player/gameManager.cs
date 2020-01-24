using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public float vida;
    public int vidaMax = 100;
    public int escudo = 0;
    public int exp = 0;
    public float expNeed = 0;
    public int nivel = 1;
    public int AmmoAuto;
    public int AmmoeExpl;
    public int AmmoFire;
    public int energia;
    public int energiaMax;
    public int combustible;
    public int combustibleMax;
    public Slider barraVida;
    public Slider barraEnergía;
    public Slider barraCombustible;

    // Start is called before the first frame update
    void Start()
    {
        vida = vidaMax;
        energia = energiaMax;
        combustible = combustibleMax;
    }

    // Update is called once per frame
    void Update()
    {
        //subida de nvel
        if(exp >= expNeed)
        {
            nivel++;
            exp = 0;
            expNeed = expNeed* 1.3f;
            vidaMax += 40;
            energiaMax += 20;
            combustibleMax += 20;
            vida = vidaMax;
            energia = energiaMax;
            combustible = combustibleMax;

        }

        //stats actuales
        barraVida.value = vida;
        barraEnergía.value = energia;
        barraCombustible.value = combustible;
        barraVida.maxValue = vidaMax;
        barraEnergía.maxValue = energiaMax;
        barraCombustible.maxValue = combustibleMax;
    }
}
