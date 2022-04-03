using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    private float velocidad = 7f; // Variable para la velocidad de la bola
    public Vector2 posicionInicial; // Vector2 para la posición inicial de la bola
    public Rigidbody2D rb; // Rigidbody2D de la bola

    public AudioClip sonidoPelota; // AudioClip para el sonido de la pelota
    private AudioSource sonidoJugador; // AudioSource para controlar el sonido de la pelota y el poste
    public AudioClip sonidoPoste; //AudioClip para el sonido del poste

    // Método que inicializa la posición de la pelota y el AudioSource sonidoJugador
    // y empieza a moverse la pelota 
    void Start()
    {
        transform.position = posicionInicial;
        sonidoJugador = GetComponent<AudioSource>();      
        Empezar(); // Método para empezar a mover la pelota
    }

    // Método donde empieza a moverse la pelota asignándole velocidad
    public void Empezar()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector2(velocidad * x, velocidad * y);
    }

    // Método para resetear la posición de la pelota y volver a moverse
    public void Reset()
    {
        transform.position = posicionInicial;
        rb.velocity = Vector2.zero;

        Empezar(); // Método para empezar a mover la pelota
    }

    // Método donde le doy rotación a la pelota y donde si pulso 'Esc' salgo del juego
    private void Update()
    {
        rb.rotation += 1.0f;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    // Método para controlar las colisiones de los jugadores con la bola
    void OnCollisionEnter2D(Collision2D micolision)
    {
        // micolision contiene toda la información de la colisión
        // transform.position es la posición de la bola
        // micolision.gameObject es el jugador
        // micolision.transform.position es la posición del jugador

        // Si choca con el jugador de la izquierda
        if (micolision.gameObject.CompareTag("Jugador1"))
        {
            // Valor de x
            int x = 1;

            // Valor de y
            int y = direccionY(transform.position, micolision.transform.position);

            // Vector de dirección
            Vector2 direccion = new Vector2(x, y);

            // Aplico velocidad
            GetComponent<Rigidbody2D>().velocity = direccion * velocidad * 1.5f;
            
            // Asigno el sonido la pelota
            sonidoJugador.PlayOneShot(sonidoPelota, 1.0f);
            
        }

        // Si choca con el jugador de la derecha
        if (micolision.gameObject.CompareTag("Jugador2"))
        {
            // Valor de x
            int x = -1;

            // Valor de y
            int y = direccionY(transform.position, micolision.transform.position);

            // Vector de dirección
            Vector2 direccion = new Vector2(x, y);

            // Aplico velocidad
            GetComponent<Rigidbody2D>().velocity = direccion * velocidad * 1.5f;

            // Asigno el sonido la pelota
            sonidoJugador.PlayOneShot(sonidoPelota, 1.0f);
        }

        // Si hay colisión que suene el sonido del poste
        // He creado una Etiqueta (tag) 'Lado1' que he asignado a los laterales 
        // de la portería que suene el poste cuando sea golpeado por la pelota
        if (micolision.gameObject.CompareTag("Lado1"))
        {
            sonidoJugador.PlayOneShot(sonidoPoste, 0.5f);
        }

    }

    // Método para calcular la direccion de Y (devuelve un número entero)
    int direccionY(Vector2 posicionBola, Vector2 posicionJugador)
    {
        if (posicionBola.y > posicionJugador.y)
        {
            return 1; // Si choca por la parte superior del jugador, sale hacia arriba
        }
        else 
        {
            return -1; // Si choca por la parte inferior del jugador, sale hacia abajo
        }


    }

    }
