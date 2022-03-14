using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unidades : MonoBehaviour
{
    protected int vidaTotal;

    protected int vidaActual;

    protected Vector3 dimensiones;

    protected int vision;

    protected bool viva;


    public string SerAtacado(int poderAtaque, string n){
        vidaActual = vidaActual - poderAtaque;
         if (vidaActual <= 0) {
            Morir(n);
        }
        return "Fue atacado  con " + poderAtaque + " puntos";
    }

    public string Nacer(){
        viva = true;
        Debug.Log("He nacido");
        return "He nacido";
    }

    // Ejercicio diseñar cómo mueren las unidades
    public void Morir(string n){
        viva = false;
        
        if(n=="null"){ 
            Debug.Log("Se destruyo el edificio");
        }else{
            Debug.Log("He muerto "+n);
        }
    }  
    // Ejercicio hacer método para saber si la unidad está viva

    public bool getViva(){
        return viva; //por defecto está en true
    }

    
}
