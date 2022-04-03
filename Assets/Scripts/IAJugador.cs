using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAJugador : MonoBehaviour
{
    public float speed = 3; // Variable para la velocidad del jugador IA
    public GameObject ball; // Objeto bola
    private Vector2 ballPos; // Vector2 para la posici�n de la bola

    // M�todo que actualiza el movimiento del jugador IA
    void Update()
    {
        Move();
    }

    // M�todo para el movimiento del jugador IA en funci�n de la posici�n de 
    // la bola
    void Move()
    {
        ballPos = ball.transform.position;

        if (transform.position.y > ballPos.y)
        {
            transform.position += new Vector3(-speed/10 * Time.deltaTime, -speed * Time.deltaTime);
        }

        if (transform.position.y <= ballPos.y)
        {
            transform.position += new Vector3(speed/10 * Time.deltaTime, speed * Time.deltaTime);
        }
    }
}
