using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    // Asigna el botón en el inspector de Unity
    public Button quitButton;

    private void Start()
    {
        // Agrega un escucha de evento al botón
        quitButton.onClick.AddListener(QuitGame);
    }

    private void QuitGame()
    {
        // Salir del juego
        Application.Quit();
        Debug.Log("Saliendo...");
    }
}
