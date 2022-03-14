using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayableCharacter : Unidades
{
    private int coste;
    private List<Superficie> superficiesPosible;
   
   
}
 enum Superficie{  // un enum es un tipo (hecho por mí) que contenga lo que yo defina
        Tierra,
        Agua,
        Montaña,
        Bosque
    }
