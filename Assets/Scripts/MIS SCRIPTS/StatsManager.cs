using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

    

public class StatsManager : MonoBehaviour
{
    // Singleton
    public static StatsManager singleton;

    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }

    }

    //MiniJuegoLLuvia

    [Header("Comida")]
    public int comida = 0;
    [SerializeField] public Text _textcomida;
    [Header("Bebida")]
    public int bebida = 0;
    [SerializeField] public Text _textbebida;

    //Monedas

   [Header("Monedas")]

   [SerializeField] public Text _monedas;
   [SerializeField] public Text scoreText;
   

    //Hambre

   [Header("Hambre")]

    [SerializeField] private float _maxHunger = 100f;
    [SerializeField] private float _hungerDeplationRate = 1f;
    public float _currentHunger;

    public float HungerPercent => _currentHunger / _maxHunger;

    //Sed

    [Header("Sed")]

    [SerializeField] private float _maxThirst = 100f;
    [SerializeField] private float _ThirstDeplationRate = 1f;
    public float _currentThirst;

    public float ThirstPercent => _currentThirst / _maxThirst;


    // Vida

    [Header("Vida")]

    [SerializeField] private float _maxStamina = 100f;
    [SerializeField] private float _staminaDeplationRate = 1f;
    [SerializeField] private float _staminaRechargeRate = 2f;
    [SerializeField] private float _staminaRechargeDelay = 1f;

    private float _currentStamina;
    private float _currentStaminaDelayCounter;
    public float StaminaPercent => _currentStamina / _maxStamina;

    

    public Image gameOver;

    public static UnityAction OnPlayerDied;


   private void Start()
    {
       
        _currentHunger = _maxHunger;
        _currentStamina = _maxStamina;
        _currentThirst = _maxThirst;

        
    }

    private void Update()
    {
        
        _monedas.text = "Dinero = " + SingletonManager.singleton.Contador;
        scoreText.text = "Score = " + SingletonManager.singleton.Score;
        _textcomida.text = "Comida = " + comida;
        _textbebida.text = "Bebida = " + bebida;

        _currentHunger -= _hungerDeplationRate * Time.deltaTime;
        _currentThirst -= _ThirstDeplationRate * Time.deltaTime;

        if(_currentHunger <= 0 || _currentThirst <= 0)
        {
            OnPlayerDied?.Invoke();
            _currentHunger = 0;
            _currentThirst = 0;

            _currentStamina -= _staminaDeplationRate * Time.deltaTime;

            if(_currentStamina <= 0)
            {
                gameOver.gameObject.SetActive(true);
            }
            //A�adir aqui que pasa cuando llegas a 0 de Stamina, es decir, GameOver
        }



    }

    public void ReplenishHungerThirst(float hungerAmount, float thirstAmount)
    {
        _currentHunger += hungerAmount;
        _currentThirst += thirstAmount;

        if (_currentHunger > _maxHunger) _currentHunger = _maxHunger;
        if (_currentThirst > _maxThirst) _currentThirst = _maxThirst;
    }

    
}


