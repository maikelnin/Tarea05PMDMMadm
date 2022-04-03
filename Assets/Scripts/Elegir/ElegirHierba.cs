using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirHierba : MonoBehaviour
{
    // Método para ir a la pantalla principal si pulsa 'Esc'
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }

    // Método que nos manda a la PantallaHierba si pulsamos el botón
    public void PantallaHierba()
    {
        SceneManager.LoadScene("PantallaHierba");
    }

    // Método que nos manda a la PantallaHierbaIA si pulsamos el botón
    public void PantallaHierbaIA()
    {
        SceneManager.LoadScene("PantallaHierbaIA");
    }


}
