using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirParque : MonoBehaviour
{
    // Método para ir a la pantalla principal si pulsa 'Esc'
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }

    // Método que nos manda a la PantallaParque si pulsamos el botón
    public void PantallaParque()
    {
        SceneManager.LoadScene("PantallaParque");
    }

    // Método que nos manda a la PantallaParqueIA si pulsamos el botón
    public void PantallaParqueIA()
    {
        SceneManager.LoadScene("PantallaParqueIA");
    }


}
