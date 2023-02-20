using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDialogo : MonoBehaviour
{

    public static ControlDialogo singleton;
    public static bool enDialogo = false;

    public GameObject dialogo;
    public Text txtDialogo;
    public Image imCara;
    //public Frase[] dialogoEnsayo;

    public ConfigDialogo configuracion;

    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }
    private void Start()
    {
        dialogo.SetActive(false);
    }

    public IEnumerator Decir(Frase[]_dialogo)
    {
        dialogo.SetActive(true);
        enDialogo = true;
        for (int i = 0; i < _dialogo.Length; i++)
        {
            txtDialogo.text = "";

            imCara.sprite = configuracion.personajes[_dialogo[i].personaje].GetCara(0);

            for (int j = 0; j < _dialogo[i].texto.Length + 1; j++)
            {
                yield return new WaitForSeconds(configuracion.tiempoLetra);
                if (SimpleInput.GetButtonDown("Fire1"))
                {
                    j = _dialogo[i].texto.Length;
                }

                txtDialogo.text = _dialogo[i].texto.Substring(0, j);

                if (j < _dialogo[i].texto.Length)
                {
                    imCara.sprite = configuracion.personajes[_dialogo[i].personaje].GetCara(ArreglarLetra(_dialogo[i].texto[j].ToString()));
                }
            }

            txtDialogo.text = _dialogo[i].texto;
            yield return new WaitForSeconds(0.5f);
            yield return new WaitUntil(() => SimpleInput.GetButtonUp("Fire1"));
        }
        dialogo.SetActive(false);
        enDialogo = false;
    }

    public string ArreglarLetra(string letra)
    {
        string resultado = letra.ToUpper();
        resultado = resultado.Replace("Á", "A");
        resultado = resultado.Replace("É", "E");
        resultado = resultado.Replace("Í", "I");
        resultado = resultado.Replace("Ó", "O");
        resultado = resultado.Replace("Ú", "U");
        resultado = resultado.Replace("Ü", "U");
        return resultado;
    }
}

[System.Serializable]
public class Frase
{
    public string texto;
    public int personaje;
}

[System.Serializable]
public class EstadoDialogo
{
    public Frase[] frases;
}

[System.Serializable]
public class CaraDialogo
{
    public string letra;
    public Sprite cara;
}

[System.Serializable]
public class PersonajeDialogo
{
    public CaraDialogo[] caras;
    public Sprite GetCara(string l)
    {
        int indice = 0;
        for (int i = 0; i < caras.Length; i++)
        {
            if (caras[i].letra == l)
            {
                indice = i;
                break;
            }
        }
        return caras[indice].cara;
    }

    public Sprite GetCara(int i)
    {
        i = Math.Clamp(i,0,caras.Length - 1);
        return (caras[i].cara);
    }
}