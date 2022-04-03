using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Método para salir del juego si pulsa 'Esc'
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    // Método que nos manda a la escena ElegirHielo si pulsamos el botón
    public void ElegirHielo()
    {
        SceneManager.LoadScene("ElegirHielo");
    }

    // Método que nos manda a la escena ElegirNormal si pulsamos el botón
    public void ElegirNormal()
    {
        SceneManager.LoadScene("ElegirNormal");

    }

    // Método que nos manda a la escena ElegirHierba si pulsamos el botón
    public void ElegirHierba()
    {
        SceneManager.LoadScene("ElegirHierba");
    }

    // Método que nos manda a la escena ElegirParque si pulsamos el botón
    public void ElegirParque()
    {
        SceneManager.LoadScene("ElegirParque");

    }
}
