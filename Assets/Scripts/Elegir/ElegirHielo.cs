using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirHielo : MonoBehaviour
{
    // Método para ir a la pantalla principal si pulsa 'Esc'
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }

    // Método que nos manda a la PantallaHielo si pulsamos el botón
    public void PantallaHielo()
    {
        SceneManager.LoadScene("PantallaHielo");
    }

    // Método que nos manda a la PantallaHieloIA si pulsamos el botón
    public void PantallaHieloIA()
    {
        SceneManager.LoadScene("PantallaHieloIA");
    }


}
