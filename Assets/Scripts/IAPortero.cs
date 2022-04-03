using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAPortero : MonoBehaviour
{
    public float speed = 3; // Variable para la velocidad del portero IA
    public GameObject ball; // Objeto bola
    private Vector2 ballPos; // Vector2 para la posici�n de la bola

    // M�todo que actualiza el movimiento del portero IA
    void Update()
    {
        Move();
    }

    // M�todo para el movimiento del portero IA en funci�n de la posici�n de 
    // la bola
    void Move()
    {
        ballPos = ball.transform.position;

        if (transform.position.y > ballPos.y)
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime);
        }

        if (transform.position.y <= ballPos.y)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime);
        }
    }
}
