using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirNormal : MonoBehaviour
{
    // Método para ir a la pantalla principal si pulsa 'Esc'
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }

    // Método que nos manda a la PantallaNormal si pulsamos el botón
    public void PantallaNormal()
    {
        SceneManager.LoadScene("PantallaNormal");
    }

    // Método que nos manda a la PantallaNormalIA si pulsamos el botón
    public void PantallaNormalIA()
    {
        SceneManager.LoadScene("PantallaNormalIA");
    }


}
