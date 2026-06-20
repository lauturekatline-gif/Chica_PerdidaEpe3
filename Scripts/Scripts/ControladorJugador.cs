using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidad = 5.0f;
    public float velocidadRotacion = 100.0f;

    void Update()
    {
        // ¡AVANZAR AUTOMÁTICAMENTE! 
        // Ya no te pide presionar W. Avanza sola todo el tiempo hacia adelante.
        transform.Translate(0, 0, velocidad * Time.deltaTime);

        // Rotación manual hacia los lados (Flechas Izquierda/Derecha o A/D)
        // Por si quieres esquivar los árboles del bosque mientras corre sola.
        float rotacion = Input.GetAxis("Horizontal") * velocidadRotacion * Time.deltaTime;
        transform.Rotate(0, rotacion, 0);
    }
}