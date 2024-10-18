using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonShop : MonoBehaviour
{
    //[SerializeField]
    TextMeshProUGUI textButton;
    [SerializeField]
    //Wallet myWallet;

    //[SerializeField]
    string nameItem = "Objeto";
    [SerializeField]
    float priceItem;

    void Start()
    {
        textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        priceItem = Random.Range(25f, 250f);
        textButton.text = priceItem.ToString() + "$";
    }
    void ClickEnBotonDeTienda()
    {
        //myWallet.RestarSaldo(nameItem,priceItem); ; ;
    }
 
}
