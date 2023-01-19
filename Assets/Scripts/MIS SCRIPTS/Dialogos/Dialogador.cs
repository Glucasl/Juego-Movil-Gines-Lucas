using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogador : MonoBehaviour
{
    public int estadoActual = 0;
    public EstadoDialogo[] estados;

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(ControlDialogo.singleton.configuracion.teclaInicioDialogo) || Input.GetKeyDown(ControlDialogo.singleton.configuracion.teclaInicioDialogo2))
            {
                StartCoroutine(ControlDialogo.singleton.Decir(estados[estadoActual].frases));
            }
        }

        //if (other.CompareTag("Player"))
        //{
        //    if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire1"))
        //    {
        //        StartCoroutine(ControlDialogo.singleton.Decir(estados[estadoActual].frases));
        //    }
        //}
    }
}
