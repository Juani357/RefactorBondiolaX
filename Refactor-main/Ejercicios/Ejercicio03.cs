using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    int resistencia;
    int vida;

    void RacibirDa�o(int da�o)
    {
     
        if (resistencia > 5)
        {
            da�o -= 2;

        }

        vida -= da�o;
        
    }
}
