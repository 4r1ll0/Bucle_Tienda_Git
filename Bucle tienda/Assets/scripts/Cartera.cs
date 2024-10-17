using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cartera : MonoBehaviour
{
    float saldo;
    [SerializeField]
    TextMeshProUGUI labelSaldo;
    [SerializeField]
    GameObject confirmarCompra;
    [SerializeField]
    GameObject nosaldo;

    void Start()
    {
        saldo = Random.Range(450f, 950f);
        labelSaldo.text = saldo.ToString("000.00") + "$";
    }

    public void RestartSaldo(float precio)
    {
        if (saldo > precio)
        {
            saldo -= precio;
            labelSaldo.text = saldo.ToString("000,00") + "$";

        }
        else
        {
            nosaldo.SetActive(true);
        }
    }


}
