using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour
{
    private Transform limites; // Transform donde guardo los l�mites

    public Vector2 Hrange = Vector2.zero; // Vector2 para l�mite horizontal
    public Vector2 Vrange = Vector2.zero; // Vector2 para l�mite vertical

    // M�todo que controla los l�mites vertical y horizontal de los jugadores
    // y porteros
    private void LateUpdate()
    {
            limites.position = new Vector3(
            Mathf.Clamp(transform.position.x, Vrange.x, Vrange.y),
            Mathf.Clamp(transform.position.y, Hrange.x, Hrange.y),
            transform.position.z
            );
    }

    // M�todo para inicializar los l�mites vertical y horizontal de los jugadores
    void Start()
    {
        limites = GetComponent<Transform>();
    }

    
}
