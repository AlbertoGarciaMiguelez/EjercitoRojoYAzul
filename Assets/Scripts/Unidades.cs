using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unidades
{

    protected float vida_total;
    protected float vida_actual;
    private Vector3 dimensiones;
    private float vision;
    protected bool viva;
    public string ser_atacado(float poderAtaque, string unidad){
        vida_actual= vida_actual-poderAtaque;
        if(vida_actual <= 0){
            morrer(unidad);
        }
        return "Fun atacado con "+ poderAtaque+ "puntos";
    }
    public string nacer(string unidad){
        viva=true;
        Debug.Log("Nacio "+unidad);
        return unidad;
    }
    public void morrer(string unidad){
        viva=false;
        Debug.Log("Murio "+unidad);
    }
    public bool getViva(){
        return viva;
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
