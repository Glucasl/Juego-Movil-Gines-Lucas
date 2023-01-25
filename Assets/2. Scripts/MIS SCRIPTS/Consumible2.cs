using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Consumible2 : MonoBehaviour
{
    public TMP_Text contadorBebida;


    // Update is called once per frame
    void Update()
    {
       contadorBebida.text = GameManager.contadorBebida.ToString(); 
    }
}
