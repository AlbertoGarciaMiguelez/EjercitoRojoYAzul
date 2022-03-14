using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainT : MonoBehaviour
{
  

    // Start is called before the first frame update
    void Start()
    {

    // Crea una clase nueva llamada triángulo, que tenga un atributo lado, un método calcular area e instanciar dos de esas clases en main imprimiendo en pantalla el área
        Triangulo t1 = new Triangulo(7f);
        float area = t1.CalcularArea();
        //Debug.Log (area);

        Triangulo t2 = new Triangulo(3.2f);
        float area2 = t2.CalcularArea();
        //Debug.Log (area2);
      
    // Crea un metodo estático calcularAreaStatic(float unLado) y llamarlo
        
        //Debug.Log (Triangulo.CalcularAreaStatic(3.9F));

    // Creamos variable estática que se suma cuando hacemos una nueva instancia
        //Debug.Log(Triangulo.MostrarCantidade());

    // Crear 1.000 triangulos de lado aleatorio, guardando los triángulos en un array

        float[] areas = new float[5]; //los arrays son fijos 
        for (int i = 0; i < areas.Length; i++) { //for para repetir algo, los arrays en principio están vacíos pero con los sitios reservados de lo que pongamos
            //areas[i] = Triangulo.CalcularAreaStatic(0.7f+2*i); //en vez de llamar a un aleatorio ponemos esto

            areas[i] = Triangulo.CalcularAreaStatic(Random.Range(0, 50));
        }
       // Debug.Log(areas[4]);
        //Debug.Log(areas[0]);


                                                        
        List<float> areasTriangulos = new List<float>(); //listas más dinámicas hechas para cambiar, lo que añades con add se pone al final;las listas a no ser que lo especifiquemos 
        float calculoAreaAleatoria;                      //están vacías, cuando hacemos el bucle for añade numeros al recorrerse.
         for(int i = 0; i < 5; i++){
            calculoAreaAleatoria = Triangulo.CalcularAreaStatic(Random.Range(0, 50));
            areas[i] = calculoAreaAleatoria;
            areasTriangulos.Add(calculoAreaAleatoria);

        }

        /*Debug.Log(areasTriangulos[4]);
        Debug.Log(areasTriangulos[0]);
        Debug.Log(areas[4]);
        Debug.Log(areas[0]);
*/
        for (int i = 0; i < areas.Length; i++) {
            //Debug.Log(areas[1]);
        }
        for (int i = 0; i < areasTriangulos.Count; i++) { //el for GENERA numeros (un int llamado i)entre 0 y el areastriangulos.count y le suma uno
            //Debug.Log(areasTriangulos[i]);
        }

        foreach (float item in areasTriangulos){ //para cada elemento de la lista crea una nueva variable lamada item(en este caso) dentro areasTriangulos
            //Debug.Log(item);                    // va elemento a elemento y ejecuta; se usa cuando ya existe, si no existe se usa un for; 
        }                                       //El foreach RECORRE
    

        // Crear una lista de 5 triángulos e imprimir su área 
        
        List<Triangulo> listaTriangulos = new List<Triangulo>();
              
        for(int i = 0; i < 5; i++){
            listaTriangulos.Add(new Triangulo(Random.Range(0,50))); //añade 5 triangulos a la lista
        }     
        foreach (Triangulo item in listaTriangulos){ 
            Debug.Log(item.CalcularArea());     //imprime el area        

        }
         //Eliminar el elemento de menor área y volver a imprimir


        int indexMin = listaTriangulos.Count + 1;
        float areaMin = 100000f;
        for(int i = 0; i < listaTriangulos.Count; i++){ //primero recorremos la lista
            
            if(listaTriangulos[i].CalcularArea() < areaMin) {     //si la posicón en la que estoy calculo su area 
                    areaMin = listaTriangulos[i].CalcularArea(); //y es menor que la minima (que va a ser menor si o si la primera vez pq es un numero muy grande)
                    indexMin = i;                               //entonces area Min es igual que el área calculada antes (si es menor) y el index coge la posición de i 
                                                                //si es mayor pasa a la sigiente posición de la lista y vuelve a hacer el bucle
            }
        }

        //borrar la posicion del area mas baja
        listaTriangulos.RemoveAt(indexMin);
        //imprimir 
        foreach (Triangulo item in listaTriangulos){ 
            Debug.Log(item.CalcularArea());           

        }
    }

}
