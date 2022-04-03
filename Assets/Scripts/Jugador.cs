using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public bool player1; // Variable para saber qui�n es el player 1
    public float speed = 3; // Variable para la velocidad del jugador
    public Rigidbody2D rb; // Rigidbody 2D del jugador

    private float moveVertical; // Variable para el movimiento vertical
    private float moveHorizontal; // Variable para el movimiento horizontal
    private Vector2 startPos; // Vector2 para la posici�n inicial del jugador

    // M�todo donde definimos la posici�n inicial del jugador y bloqueamos
    // el movimiento del cursor del rat�n
    void Start()
    {
        startPos = transform.position;
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // M�todo donde asignamos las teclas del jugador 1 y 2 y le damos velocidad
    void Update()
    {
        if (player1)
        {
  
            moveVertical = Input.GetAxisRaw("Vertical");
            moveHorizontal = Input.GetAxisRaw("Horizontal");
        }
        else
        {

            moveVertical = Input.GetAxisRaw("Vertical2");
            moveHorizontal = Input.GetAxisRaw("Horizontal2");
        }

        rb.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);
    }

    // M�todo para resetear la posici�n del jugador cuando se marca 1 gol
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
    }


}
