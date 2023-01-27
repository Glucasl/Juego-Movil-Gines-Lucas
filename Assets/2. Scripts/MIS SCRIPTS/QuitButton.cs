using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    // Este Script nos permite salir del juego pulsando un boton en el canvas
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
