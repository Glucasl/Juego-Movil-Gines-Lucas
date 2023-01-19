using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;


    void FixedUpdate()
    {
        float translation = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        transform.Translate(translation, 0, 0);
        // Limita el rango del player en el eje X entre 11 y -11
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -11, 11), transform.position.y, transform.position.z);
    }

    private void Update()
    {

    }
}