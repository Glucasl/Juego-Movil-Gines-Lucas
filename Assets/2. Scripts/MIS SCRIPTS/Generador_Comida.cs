using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_Comida : MonoBehaviour
{
    public GameObject[] Comidas;
    public GameObject ComidaMostrada;
    public bool Mostrando;
    public float tiempomMin, tiempoMax, hambreSumada;
    [SerializeField] private StatsManager _statsManagerF;

    [System.Obsolete]
    private void Start()
    {
        DestroyObject(ComidaMostrada);
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
        _statsManagerF._currentHunger = 100;
        Mostrando = false;
        DestroyObject(ComidaMostrada);
        Invoke("Generar", Random.Range(tiempomMin, tiempoMax));
    }
    void Generar()
    {
        if (!Mostrando)
        {
            Mostrando = true;
            ComidaMostrada = Instantiate(Comidas[Random.Range(0, Comidas.Length)], transform.position, Quaternion.identity);
            ComidaMostrada.transform.parent = transform;
            ComidaMostrada.transform.localScale *=2;
        }
    }
    
}
