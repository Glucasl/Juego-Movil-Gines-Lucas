using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CuentaAtras : MonoBehaviour
{
    public float tiempi;
    public float tiempiMin;
    public Text crono;
    TimeSpan tiempo;

    private void Start()
    {
        while (tiempi >= 60)
        {
            tiempiMin++;
            tiempi = tiempi - 60;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        tiempi = tiempi - Time.deltaTime;
        ActualizarCronometro();
        if (tiempi <= 0)
        {
            if (tiempiMin > 0)
            {
                tiempiMin--;
                tiempi = 59;
            }
            else
            {
                SceneManager.LoadScene("Principal");
            }

            
        }
    }
    public void ActualizarCronometro()
    {

        int a = Convert.ToInt32(tiempi);
        
        
        crono.text = tiempiMin.ToString() + " : " + a.ToString();
       
    }
}
