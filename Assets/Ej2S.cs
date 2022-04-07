using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2S : MonoBehaviour
{
    // Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
    // Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
    // Luego indicar cuánto dinero sobra o falta.

    public int producto1;
    public int producto2;
    public int producto3;
    public int montodedinero;

    // Start is called before the first frame update
    void Start()
    {
        int preciototal = producto1 + producto2 + producto3;
        int restante = montodedinero - preciototal;
        int faltante = preciototal - montodedinero;
        if (preciototal < montodedinero)
        {
            Debug.Log("Es posible comprar todos los productos con esta suma de dinero");
            Debug.Log("El dinero sobrante es: " + restante);
        }

        else
        {
            Debug.Log("No es posible comprar todos los productos con esta suma de dinero");
            Debug.Log("El dinero faltante es: " + faltante);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
