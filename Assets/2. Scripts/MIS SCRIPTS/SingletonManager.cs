using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonManager : MonoBehaviour
{
 public static SingletonManager singleton;

    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    private int _contador;
    public int Contador
    {
        get { return _contador; }
        set { _contador = value; }
    }

    public int Score { get; set; }

}
