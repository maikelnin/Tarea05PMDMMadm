using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // M�todo para salir del juego si pulsa 'Esc'
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    // M�todo que nos manda a la escena ElegirHielo si pulsamos el bot�n
    public void ElegirHielo()
    {
        SceneManager.LoadScene("ElegirHielo");
    }

    // M�todo que nos manda a la escena ElegirNormal si pulsamos el bot�n
    public void ElegirNormal()
    {
        SceneManager.LoadScene("ElegirNormal");

    }

    // M�todo que nos manda a la escena ElegirHierba si pulsamos el bot�n
    public void ElegirHierba()
    {
        SceneManager.LoadScene("ElegirHierba");
    }

    // M�todo que nos manda a la escena ElegirParque si pulsamos el bot�n
    public void ElegirParque()
    {
        SceneManager.LoadScene("ElegirParque");

    }
}
