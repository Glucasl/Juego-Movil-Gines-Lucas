using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pausa : MonoBehaviour
{
    public static Pausa instance;
    bool active;
    
    public GameObject pausa, HUDjuego, fundido;
    public Button boton;

    // Start is called before the first frame update
    void Start()
    {
        pausa.SetActive(false);
        fundido.SetActive(false);
        HUDjuego.SetActive(true);
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                MenuPausaOn();
                
            }      
            else if (Time.timeScale == 0)
            {
                MenuPausaOff();
            }
        }        
    }
    public void MenuPausaOn()
    {
        fundido.SetActive(true);
        pausa.SetActive(true);
        HUDjuego.SetActive(false);
        Time.timeScale = 0;
        boton.Select();
    }
    public void MenuPausaOff()
    {
        fundido.SetActive(false);
        pausa.SetActive(false);
        HUDjuego.SetActive(true);
        Time.timeScale = 1;
    }
}
