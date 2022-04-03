using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject bola; // Variable Objeto para la bola

    public GameObject portero1; // Variable Objeto para el portero1
    public GameObject portero2; // Variable Objeto para el portero2

    public GameObject jugador1; // Variable Objeto para el jugador1
    public GameObject jugador2; // Variable Objeto para el jugador2

    public GameObject jugador1Gol; // Variable Objeto para la línea de gol 1
    public GameObject jugador2Gol; // Variable Objeto para la línea de gol 2

    private int golesP1; // Variable para guardar los goles del player 1
    private int golesP2; // Variable para guardar los goles del player 1

    public Text puntuacionP1; // Guarda la puntación del player 1
    public Text puntuacionP2; // Guarda la puntación del player 2

    public int maxPuntuacion = 5; // Variable con la máxima puntuación (5)

    public Text textoContador; // Variable para el texto del contador de tiempo

    public float contador = 300; // Variable que guarda el valor del contador
    private float minutos; // Variable para los minutos del contador
    private float segundos; // Variable para los segundos del contador

    public bool IAGame; // Variable que nos indica si es o no un juego con IA

    // Método que comprueba qué player ha marcado los 5 goles (máxima puntuación
    // definida) y nos manda a la escena de victoria correspondiente
    public void ComprobarVictoria()
    {
        if (golesP1 >= maxPuntuacion)
        {
            SceneManager.LoadScene("VictoriaJugador1");
        }

        if (golesP2 >= maxPuntuacion)
        {
            SceneManager.LoadScene("VictoriaJugador2");
        }
    }

    // Método para resetear la posición de la bola, los jugadores y los porteros
    private void ResetearPosicion()
    {
        if (IAGame)
        {
            bola.GetComponent<Bola>().Reset();
            portero1.GetComponent<Portero>().Reset();
            jugador1.GetComponent<Jugador>().Reset();
          
        } else
        {
            bola.GetComponent<Bola>().Reset();
            portero1.GetComponent<Portero>().Reset();
            portero2.GetComponent<Portero>().Reset();
            jugador1.GetComponent<Jugador>().Reset();
            jugador2.GetComponent<Jugador>().Reset();
        } 

    }

    // Método que suma los goles, actualiza la puntuación y comprueba si el player 1
    // ha ganado el partido además de llamar al método ResetearPosicion() porque se 
    // ha metido 1 gol
    public void Jugador1Gol()
    {
        golesP1++;
        puntuacionP1.text = golesP1.ToString();
        ComprobarVictoria();
        ResetearPosicion();
    }

    // Método que suma los goles, actualiza la puntuación y comprueba si el player 2
    // ha ganado el partido además de llamar al método ResetearPosicion() porque se 
    // ha metido 1 gol
    public void Jugador2Gol()
    {
        golesP2++;
        puntuacionP2.text = golesP2.ToString();
        ComprobarVictoria();
        ResetearPosicion();
    }

    // Método que actualiza el contador de tiempo hasta que sea 0. Cuando lo sea
    // compara la puntuación de ambos player y nos manda la escena correspondiente
    public void Update()
    {
        if (contador > 0)
        {
            contador = contador - 1 * Time.deltaTime;
            minutos = (int)(contador / 60);
            segundos = (int)(contador % 60);

            if (segundos < 10)
            {
                textoContador.text = minutos.ToString() + ":0" + segundos.ToString();
            } else
            {
                textoContador.text = minutos.ToString() + ":" + segundos.ToString();
            }
            
        }
        else
        {
            if (golesP1 > golesP2)
            {
                SceneManager.LoadScene("VictoriaJugador1");
            } else if (golesP1 < golesP2)
            {
                SceneManager.LoadScene("VictoriaJugador2");
            } else if (golesP1 == golesP2)
            {
                SceneManager.LoadScene("Empate");
            }
        }

    }

}
