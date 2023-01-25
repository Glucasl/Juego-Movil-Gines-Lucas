using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    // Asigna el botón en el inspector de Unity
    public Button restartButton;

    private void Start()
    {
        // Agrega un escucha de evento al botón
        restartButton.onClick.AddListener(RestartScene);
    }

    private void RestartScene()
    {
        // Recargar la escena actual
        SingletonManager.singleton.Contador = 0;
        SceneManager.LoadScene(0);
    }
}