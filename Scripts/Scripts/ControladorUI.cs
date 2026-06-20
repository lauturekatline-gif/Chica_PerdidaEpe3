using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorUI : MonoBehaviour
{
    // Aquí arrastraremos al personaje desde Unity para poder controlarlo
    public Animator miAnimator; 
    private bool estaPausado = false;

    // 1. Función para el botón INICIA
    public void EmpezarJuego()
    {
        Time.timeScale = 1f; // Descongela el tiempo del juego
        estaPausado = false;
        Debug.Log("¡Juego Iniciado!");
    }

    // 2. Función para el botón PAUSA
    public void AlternarPausa()
    {
        estaPausado = !estaPausado;

        if (estaPausado)
        {
            Time.timeScale = 0f; // Congela el juego por completo
            Debug.Log("Juego Pausado");
        }
        else
        {
            Time.timeScale = 1f; // Devuelve el juego a la normalidad
            Debug.Log("Juego Reanudado");
        }
    }

    // 3. Función para el botón BAILAR (Frena al jugador y activa la Macarena)
    public void HacerBailar()
    {
        Time.timeScale = 1f; // Nos aseguramos de que el juego no esté congelado

        // Activa la animación "Dance" que pusimos en la cuadrícula del Animator
        miAnimator.Play("Dance"); 

        // TRUCO DEFINITIVO: Buscamos el script que hace correr al personaje
        ControladorJugador scriptJugador = miAnimator.GetComponent<ControladorJugador>();
        
        if (scriptJugador != null)
        {
            scriptJugador.velocidad = 0f; // Ponemos su velocidad en cero para que NO se deslice
        }

        Debug.Log("¡Personaje Bailando de forma Estática!");
    }
}