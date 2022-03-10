using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo
{

private double lado;
private static int triangulos = 0;
         
    public Triangulo(double l){
        lado = l;
        triangulos++;
    }

    public double calcularArea(){
        
        return lado*lado/2;
    } 
    public static double calcularArea(double unlado){
        
        return unlado*unlado/2;
    }

    public static double calcularAreaS(double unlado){
        
        return unlado*unlado/2;
    }
    public static double mostrarCantidad(){
        return triangulos;
    }

    
     
    
}
