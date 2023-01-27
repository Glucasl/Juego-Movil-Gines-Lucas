using UnityEngine;
using System.Collections;


//En este script creamos un controlador de ciclo de dia y noche.
public class DayNightController : MonoBehaviour {

    public Light sun;
    public float secondsInFullDay = 120f;
    public GameObject luces;


    [Range(0,1)]
    public float currentTimeOfDay = 0;

    [HideInInspector]
    public float timeMultiplier = 1f;

    float sunInitialIntensity;

    //Iniciamos la intesidad del sol
    void Start() {
        sunInitialIntensity = sun.intensity;
    }

    //actualizamos la posicion del sol y el paso del dia
    void Update() {

        UpdateSun();

 
        currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;


        if (currentTimeOfDay >= 1) {
            currentTimeOfDay = 0;
        }
    }

    //Este metodo actualiza la intensidad y posicion del sol dependiendo del tiempo del dia que haya pasado, para ello variamos la intesidad en 3 fases, dia, tarde y noche.
    void UpdateSun() {

        sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 170, 0);


        float intensityMultiplier = 1;
       
        if (currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f) {
            intensityMultiplier = 0;
            
        }
        
        else if (currentTimeOfDay <= 0.25f) {

            intensityMultiplier = Mathf.Clamp01((currentTimeOfDay - 0.23f) * (1 / 0.02f));
            luces.SetActive(false);
        }

        else if (currentTimeOfDay >= 0.73f) {
            intensityMultiplier = Mathf.Clamp01(1 - ((currentTimeOfDay - 0.73f) * (1 / 0.02f)));

            luces.SetActive(true);
        }

        sun.intensity = sunInitialIntensity * intensityMultiplier;
    }
}