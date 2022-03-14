using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrero : Militar
{
    public Guerrero(string n, int puntosAtaque){ //constructor
        Nacer();
        velocidadMovimiento = 40;
        nombre = n; 
        vidaTotal = 500;
        vidaActual = vidaTotal;
        attackPower = puntosAtaque;
        Debug.Log("Creado guerrero " + nombre);
    }
    

}
