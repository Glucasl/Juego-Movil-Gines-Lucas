using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambioFOHDIA33 : MonoBehaviour
{
    [SerializeField] private GameObject Transicion;
    [SerializeField] private GameObject BlackScreen;
    [SerializeField] private float wait = 2;

        private DayNightController dayNightController;

    private void Start() {
        // Obtiene una referencia al componente DayNightController
        dayNightController = FindObjectOfType<DayNightController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SingletonManager.singleton.timeDay =  dayNightController.currentTimeOfDay;
            StartCoroutine(PasarRitmo());
        }
    }

    public void PRitmo()
    {
        StartCoroutine(PasarRitmo());
    }

    public IEnumerator PasarRitmo()
    {
        Transicion.SetActive(true);
        BlackScreen.SetActive(true);
        Time.timeScale = 1f;
        yield return new WaitForSeconds(wait);
        Time.timeScale = 1f;
        SceneManager.LoadScene(18);
    }
}
