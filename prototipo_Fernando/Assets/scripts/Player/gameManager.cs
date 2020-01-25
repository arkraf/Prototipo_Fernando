using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public float vida;
    public int vidaMax = 100;
    public float escudo = 0;
    public float escudoMax;
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

    [Header("BarraPj")]

    public Slider barraVida;
    public Slider barraEnergía;
    public Slider barraCombustible;
    public Slider barraEscudo;
    public Slider barraExp;
    public Text contadorHP;
    public Text contadorEnergia;
    public Text contadorCombustible;
    public Text contadorExp;
    public Text contadorEscudo;

    [Header("Respawn")]

    public Transform player;
    public Transform respawn;

    // Start is called before the first frame update
    void Start()
    {
        vida = vidaMax;
        energia = energiaMax;
        combustible = combustibleMax;

        respawn.position = player.position;
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
        barraEscudo.value = escudo;
        barraEscudo.maxValue = escudoMax;
        barraExp.value = exp;
        barraExp.maxValue = expNeed;
        contadorHP.text = "Vida :  " + vida;
        contadorEnergia.text = "Energía :  " + energia;
        contadorCombustible.text = "Combustible :  " + combustible;
        contadorExp.text = "Exp";
        contadorEscudo.text = "Escudo : " + escudo;

        //Respawn
        if (vida <= 0)
        {
            player.position = respawn.position;

            vida = vidaMax;
            energia = energiaMax;
            combustible = combustibleMax;
            escudo = 0;
        }

    }
}
