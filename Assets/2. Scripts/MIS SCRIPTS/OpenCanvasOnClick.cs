using UnityEngine;
using UnityEngine.UI;


//Este script nos permite activar o desactivar el canvas.
public class OpenCanvasOnClick : MonoBehaviour
{
    public Canvas canvas;

    private void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        canvas.gameObject.SetActive(true);
    }
}