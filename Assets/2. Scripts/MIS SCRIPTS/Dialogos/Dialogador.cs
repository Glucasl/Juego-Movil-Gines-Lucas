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

            StartCoroutine(ControlDialogo.singleton.Decir(estados[estadoActual].frases));
            //if (SimpleInput.GetKeyDown(ControlDialogo.singleton.iniciarDialogo))
            //{
            //    StartCoroutine(ControlDialogo.singleton.Decir(estados[estadoActual].frases));
            //}
        }

        //if (other.CompareTag("Player"))
        //{
        //    if (SimpleInput.GetButtonDown("Fire1"))
        //    {
        //        StartCoroutine(ControlDialogo.singleton.Decir(estados[estadoActual].frases));
        //    }
        //}
    }
}
