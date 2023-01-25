using UnityEngine;
using UnityEngine.UI;

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