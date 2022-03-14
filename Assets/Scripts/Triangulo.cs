using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Creamos una clase Triangulo(este script) con unos atributos y métodos propios, que luego en Main modificamos creando nuevos objetos Triangulo, dándole los valores que queramos
//y mostrándolos por pantalla
public class Triangulo : MonoBehaviour
{
    //clase = molde; objeto = realidad
    public float lado;

    private static int cantidadeTriangulos = 0; //static, que pertenece solo a la CLASE
    public Triangulo(float l){ // método constructor que se debe llamar como la clase
        lado = l;
        cantidadeTriangulos++; //++ suma 1 Para que muestre cuando se suma un triángulo (Porque cuando haces un new Triangulo tiene que coloarse aquí cantidadeTriangulos ++)
    }

    public float CalcularArea() {
        return lado*lado/2;
       
    }

    public static float CalcularAreaStatic(float unLado){ //método estático que recibe por parámetros, puestos en los parentesis. No te obliga a hacer un new Triangulo en main
        return unLado*unLado/2;                          //Los estáticos es de la clase, no del objeto
    }

    public static int MostrarCantidade(){ //como la variable es privada hacemos un método público que lo muestre
        return cantidadeTriangulos;
    }
}
