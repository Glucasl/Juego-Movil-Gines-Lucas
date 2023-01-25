using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Consumible1 : MonoBehaviour
{
    public TMP_Text contadorComida;


    // Update is called once per frame
    void Update()
    {
       contadorComida.text = GameManager.contadorComida.ToString(); 
    }
}
