using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambioComidaDIA33 : MonoBehaviour
{
    [SerializeField] private GameObject Transicion;
    [SerializeField] private GameObject BlackScreen;
    [SerializeField] private float wait = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Pcomida();
        }
    }

    public void Pcomida()
    {
        StartCoroutine(PasarComida());
    }

    public IEnumerator PasarComida()
    {
        Transicion.SetActive(true);
        BlackScreen.SetActive(true);
        Time.timeScale = 1f;
        yield return new WaitForSeconds(wait);
        Time.timeScale = 1f;
        SceneManager.LoadScene(19);
    }
}
