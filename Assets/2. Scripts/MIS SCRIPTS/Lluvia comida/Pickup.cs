using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
        public int contadorComida;
        public int contadorBebida;
        public Text comidaTexto;
        public Text bebidaTexto;


    void Update(){

        comidaTexto.text = "Comida: " + GameManager.contadorComida;
        bebidaTexto.text = "Bebida: " + GameManager.contadorBebida;
    }

    private void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.tag == "Comida"){

            GameManager.contadorComida = GameManager.contadorComida +1;
            Destroy(other.gameObject);
            
        } 
        else if (other.gameObject.tag == "Bebida"){

            GameManager.contadorBebida = GameManager.contadorBebida +1;
            Destroy(other.gameObject);
        }
    }
}









