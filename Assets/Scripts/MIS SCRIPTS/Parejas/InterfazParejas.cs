using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class InterfazParejas : MonoBehaviour
{
    public GameObject menu;
    public GameObject menuganador;
    public bool menuMostrado;
    public Text txtmenuGandor;

    public void MostrarMenu()
    {
        menu.SetActive(true);
        menuMostrado = true;
    }
    
    public void MostrarMenuGanador()
    {
        menuganador.SetActive(true);
        menuMostrado = true;
    }

    public void EsconderMenu()
    {
        menu.SetActive(false);
        menuMostrado = false;
    }
    
    public void VolverAlPrincpal()
    {
        SceneManager.LoadScene("Principal");
    }


}
