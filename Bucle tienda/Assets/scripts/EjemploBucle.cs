using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploBucle : MonoBehaviour
{
    public int[] arrayNumeros;

    void Start()
    {
        


        int sumaDeNotas = 0;
        int notaMasBaja = arrayNumeros[0];
        int notaMasAlta = arrayNumeros[0];


        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            sumaDeNotas += arrayNumeros[i];
            
            if (notaMasBaja > arrayNumeros[i])
            {
                notaMasBaja = arrayNumeros[i];
            }
            if (notaMasAlta < arrayNumeros[i])
            {
                notaMasAlta = arrayNumeros[i];
            }


                Debug.Log("nota de ejercicio" + i + " = " + arrayNumeros[i]);

        }
    
        int notaMedia = sumaDeNotas / arrayNumeros.Length;
        Debug.Log("nota media" + notaMedia + "nota alta" + notaMasAlta + "nota baja" + notaMasBaja);

        

    }

}
