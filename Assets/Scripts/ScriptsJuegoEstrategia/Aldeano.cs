using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldeano : Civil
{

    public Aldeano(string n){ //constructor
        Nacer();
        velocidadMovimiento = 50;
        vidaTotal = 100;
        vidaActual = vidaTotal;
        nombre = n; // nombre =  listaNombres[Random.Range(0, listaNombres.Count)]; Como lo pusimos en el main lo quitamos de aquí
        //nombre = "Junkook"; (todos se llamarían jungkook)
        Debug.Log("Creado aldeano" + nombre);
            
        }

    public string Trabajar(){
        if (!viva){
            return "No puedo, estoy muerto";
        }
        Debug.Log("Estoy trabajando");
        return "Estoy trabajando";
    }

    public override string ToString() {

      return "Nombre: " + nombre;
        
    }
 
}
