using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool jugador1Gol; // Variable para saber de qu� player ha sido el gol
    public GameObject gameManager; // Objeto GameManager

    public AudioClip sonidoGol; // AudioClip para el sonido del gol
    private AudioSource sonido; // AudioSource para controlar el sonido del gol

    // M�todo para inicializar el AudioSource sonido
    private void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    // M�todo que detecta la colisi�n con las l�neas de gol, llama a los m�todos
    // del GameManager que controlan al jugador1 y 2, adem�s de activar el sonido
    // del gol
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Bola"))
        {     

            if (jugador1Gol)
            {
                
                gameManager.GetComponent<GameManager>().Jugador1Gol();
                sonido.PlayOneShot(sonidoGol, 1.0f);
            }
            else
            {
                gameManager.GetComponent<GameManager>().Jugador2Gol();
                sonido.PlayOneShot(sonidoGol, 1.0f);
            }
        }

    }

    
}
