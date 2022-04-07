using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1S : MonoBehaviour
{
    //Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.

    public int valor1;
    public int valor2;

    // Start is called before the first frame update
    void Start()
    {
        if (valor1 == valor2) {
            Debug.Log("Ambos valores tienen el mismo valor");
        }

        else
        {
            Debug.Log("No tienen el mismo valor");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
