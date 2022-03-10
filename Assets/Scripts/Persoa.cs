using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persoa : PC
{

    private float vel_mov;
    protected string name;
    public static List<string> listaNames = new List<string>(){"Alberto","Antia","Juan","Miguel","Santi","Elias","Issac"};
    public string move_terra(){
        return "Se mueve";
    }
    public string getNome(){
        return name;
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
