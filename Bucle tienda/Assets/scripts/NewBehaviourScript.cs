using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ArrayStats : MonoBehaviour
{
    void Start()
    {
        int[] numeros = { 3, 4, 7, 9 };
        MostrarDatos(numeros);
    }

    void MostrarDatos(int[] array)
    {
        // Mostrar los n�meros
        Debug.Log("N�meros en el array:");
        foreach (int num in array)
        {
            Debug.Log(num);
        }

        // Calcular y mostrar la media
        float media = CalcularMedia(array);
        Debug.Log("Media: " + media);

        // Calcular y mostrar el m�nimo
        int minimo = CalcularMinimo(array);
        Debug.Log("M�nimo: " + minimo);

        // Calcular y mostrar el m�ximo
        int maximo = CalcularMaximo(array);
        Debug.Log("M�ximo: " + maximo);
    }

    float CalcularMedia(int[] array)
    {
        int suma = 0;
        foreach (int num in array)
        {
            suma += num;
        }
        return (float)suma / array.Length;
    }

    int CalcularMinimo(int[] array)
    {
        int minimo = array[0];
        foreach (int num in array)
        {
            if (num < minimo)
            {
                minimo = num;
            }
        }
        return minimo;
    }

    int CalcularMaximo(int[] array)
    {
        int maximo = array[0];
        foreach (int num in array)
        {
            if (num > maximo)
            {
                maximo = num;
            }
        }
        return maximo;
    }
}


