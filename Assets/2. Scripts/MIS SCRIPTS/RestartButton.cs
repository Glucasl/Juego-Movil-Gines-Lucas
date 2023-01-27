using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    // Este Boton nos permite reinciar el juego reinciando el dinero del juego.
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