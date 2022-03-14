using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Militar : Persona
{
    public int attackPower;
    private int attackRange;
   /* public Militar(string n){ //constructor
        Nacer();
        velocidadMovimiento = 40;
        nombre = n; 
        vidaTotal = 500;
        vidaActual = vidaTotal;
        attackPower = 10;
        Debug.Log("Creado militar " + nombre);
        }

    public Militar(string n, int puntosAtaque){ //constructor con puntos de ataque (en main puedes usar el anterior o este dependiendo de lo que neesites)
        Nacer();
        velocidadMovimiento = 40;
        nombre = n; 
        vidaTotal = 500;
        vidaActual = vidaTotal;
        attackPower = puntosAtaque;
        Debug.Log("Creado militar " + nombre);
        }

       /* public Militar(string n, int  attack = 10){ //constructor
        Nacer();
        velocidadMovimiento = 40;
        nombre = n; 
        vidaTotal = 500;
        vidaActual = vidaTotal;
        attackPower = attack;
        Debug.Log("Creado militar " + nombre);
        }
        */ //Otra foma, se pondría este solo 
    public int Atacar(){
         if (!viva){
            return 0; //porque no puede atacar entonces devuelve 0
        }
        Debug.Log(nombre + " ataco con " + attackPower);
        return attackPower;
    }

    public override string ToString() {

      return "Nombre: " + nombre;  

    }
 
}
