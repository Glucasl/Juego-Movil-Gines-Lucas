using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_Bebida : MonoBehaviour
{
    public GameObject[] Bebidas;
    public GameObject BebidaMostrada;
    public bool Mostrando;
    public float tiempomMin, tiempoMax, SedSumada;
    [SerializeField] private StatsManager _statsManagerD;

    [System.Obsolete]
    private void Start()
    {
       // DestroyObject(BebidaMostrada);
        BebidaMostrada.SetActive(false);
        Generar();
    }

    [System.Obsolete]
    void OnTriggerEnter(Collider col)
    {

        Comer();
    }

    [System.Obsolete]
    public void Comer()
    {
        _statsManagerD._currentThirst = 100;
        Mostrando = false;
        DestroyObject(BebidaMostrada);
        Invoke("Generar", Random.Range(tiempomMin, tiempoMax));
    }
    void Generar()
    {
        if (!Mostrando)
        {
            Mostrando = true;
            BebidaMostrada = Instantiate(Bebidas[Random.Range(0, Bebidas.Length)], transform.position, Quaternion.identity);
            BebidaMostrada.transform.parent = transform;
            BebidaMostrada.transform.localScale *= 2;
        }
    }
}
