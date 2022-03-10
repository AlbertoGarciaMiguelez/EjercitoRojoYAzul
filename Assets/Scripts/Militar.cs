using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Militar : Persoa
{
    private float ap;
    private float ar;
    
    public Militar(string n, float h){
        nacer(n);
        viva= true;
        name=n;
        vida_total= 500;
        vida_actual=vida_total;
        ap=h;
        Debug.Log("Creado Militar "+name);
    }
    public float Atacar(){
        if(!viva){
            return 0;
        }
        Debug.Log("Militar  ataca a aldeano  con "+ ap);
        return ap;
    }
    public override string ToString(){
        string texto= "Militiar: El daño es "+ap.ToString()+" la vida actual es "+vida_actual.ToString()+" vida total es "+vida_total+" el nombre es "+name;
        
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
