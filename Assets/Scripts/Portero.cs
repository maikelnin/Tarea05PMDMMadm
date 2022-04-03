using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portero : MonoBehaviour
{
    public bool player1; // Variable para saber quién es el player 1
    public float speed = 3; // Variable para la velocidad del portero
    public Rigidbody2D rb; // Rigidbody 2D del portero

    private float move;  // Variable para el movimiento vertical
    private Vector2 startPos; // Vector2 para la posición inicial del portero

    // Método donde definimos la posición inicial del portero
    void Start()
    {
        startPos = transform.position;
    }

    // Método donde asignamos las teclas del portero 1 y 2 y le damos velocidad
    void Update()
    {
        if (player1)
        {
            move = Input.GetAxisRaw("Vertical");
        }
        else
        {

            move = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, move * speed);
    }

    // Método para resetear la posición del portero cuando se marca 1 gol
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
    }
}
