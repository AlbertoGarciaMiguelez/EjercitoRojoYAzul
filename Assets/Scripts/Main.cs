using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        
        List<Aldeano> aldeanosRojos = new List<Aldeano>();
        List<Militar> militarRojo = new List<Militar>();
        List<Aldeano> aldeanosAzules = new List<Aldeano>();
        List<Militar> militarAzules = new List<Militar>();


        List<Aldeano> listaAldeanos = new List<Aldeano>();
        List<Militar> listaMilitar = new List<Militar>();


        string nomea = Persoa.listaNames[Random.Range(0,Persoa.listaNames.Count)];
        aldeanosRojos= new List<Aldeano>(){new Aldeano(nomea)};
        string nomea2 = Persoa.listaNames[Random.Range(0,Persoa.listaNames.Count)];
        aldeanosAzules= new List<Aldeano>(){new Aldeano(nomea2)};
        

        int x=10;
        for (int i=0; i<2; i++){
            string nome = Persoa.listaNames[Random.Range(0,Persoa.listaNames.Count)];
            //militarRojo = new List<Militar>(){new Militar(nome, x)};
            militarRojo.Add(new Militar(nome, x));
            x=x+10;
        }

        int y=10;
        for (int i=0; i<2; i++){
            string nome = Persoa.listaNames[Random.Range(0,Persoa.listaNames.Count)];
            //militarAzules = new List<Militar>(){new Militar(nome, y)};
            militarAzules.Add(new Militar(nome, y));
            y=y+10;
        }

        int atacante= Random.Range(0, 2);
        int defensor;
        if(atacante==0){
            defensor=1;
        }else{
            defensor=0;
        }
        List<List<Aldeano>> aldeanos= new List<List<Aldeano>>();
        aldeanos.Add(aldeanosAzules);
        aldeanos.Add(aldeanosRojos);
        List<List<Militar>> militares=new List<List<Militar>>();
        militares.Add(militarAzules);
        militares.Add(militarRojo);
        
        do{
            int militaraleatorio= Random.Range(0, militarAzules.Count);
            bool vivo = militarAtacaAldeano(aldeanosRojos[0], militarAzules[militaraleatorio]);
            
            if(vivo){
                militarAtacaAldeano(aldeanosAzules[0], militarRojo[militaraleatorio]);
            }
            
        }while(aldeanosAzules[0].getViva() && aldeanosRojos[0].getViva());
        
        
    
        /*List<string> nombres = new List<string>();

        List<Aldeano> listaAldeanos = new List<Aldeano>();
        List<Militar> listaMilitar = new List<Militar>();
        
        
        for (int i=0; i<1; i++){
            string nomea = Persoa.listaNames[Random.Range(0,Persoa.listaNames.Count)];
            Aldeano temporal= new Aldeano(nomea);
            
            temporal.Trabajar();
            listaAldeanos.Add(temporal);
            string nomea2 = Persoa.listaNames[Random.Range(0,Persoa.listaNames.Count)];
            Militar unidad = new Militar(nomea2);
            listaMilitar.Add(unidad);
            
            Debug.Log(unidad.ToString());
            Debug.Log(temporal.ToString());
            for (int x=0; x<10; x++){
                temporal.ser_atacado(unidad.Atacar(), nomea);
                if(!temporal.getViva()){
                    temporal=null;
                    break;
                }
            }
            
        }
        
        
       /* List<Triangulo> listaTriangulo = new List<Triangulo>();
        List<double> lista = new List<double>();
        /*Triangulo t1= new Triangulo(2.3f);
        double area= t1.calcularArea();
        //Debug.Log(area);
        Triangulo t2= new Triangulo(3.3f);
        double area2= t2.calcularArea();
        //Debug.Log(area2);

        double[] areas = new double[5];
        

        for (int i = 0; i < 5; i++){
            Triangulo t1= new Triangulo(Random.Range(0, 10));
            listaTriangulo.Add(t1);

        }
        double x= 10000;
        int contador= 0;
        foreach (Triangulo item in listaTriangulo)
        {
            contador++;
            Debug.Log(item.calcularArea());

            if(x > item.calcularArea()){
                x=item.calcularArea();
            }
            if(contador==5){
                Debug.Log("Valor mas pequeño "+x);
            }
        }


        //Debug.Log(Triangulo.mostrarCantidad());
        // Crea una clase nova chamado triangulo que teña un atributo lado un metodo calcular area e instancia duas desas clases no main, imprimindo por pantalla a area.
        */
    }
    
    public bool militarAtacaAldeano( Aldeano a, Militar m){    
        
        a.ser_atacado(m.Atacar(),m.getNome());
        return a.getViva();

    }

    void Update()
    {
        
    }
}
