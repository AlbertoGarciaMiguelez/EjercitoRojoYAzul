using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificios : PlayableCharacter
{
    private tipoEdificio tipo;
    private string nombre;
     public Edificios(string n, tipoEdificio t){ //constructor
        Nacer(); 
        vidaTotal = 500;
        tipo=t;
        n=nombre;
        vidaActual = vidaTotal;
        Debug.Log("Creado edificio "+tipo+" "+nombre);
    }
    
}
//poner los enumerados fuera de la clase para que todas las clases puedan usarlos
public enum tipoEdificio { 
        Granja,
        Casa,
        Cuartel,
        Iglesia,
        Castillo
    }
