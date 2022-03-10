using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldeano : Civil
{
    
    public Aldeano(string n){
        nacer(n);
        name = n;
        vida_total= 100;
        vida_actual=vida_total;
        Debug.Log("Creado aldeano "+name);
    }
    public string Trabajar(){
        Debug.Log("Trabajando");
        if(!viva){
            return "Non podo, estou morto";
        }
        return "trabaja";
    }
    public override string ToString(){
        string texto= "Aldeano: La vida actual es "+vida_actual.ToString()+" vida total es "+vida_total+" el nombre es "+name;
        
        return texto;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
