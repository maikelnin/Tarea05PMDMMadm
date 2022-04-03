using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirHielo : MonoBehaviour
{
    // M�todo para ir a la pantalla principal si pulsa 'Esc'
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }

    // M�todo que nos manda a la PantallaHielo si pulsamos el bot�n
    public void PantallaHielo()
    {
        SceneManager.LoadScene("PantallaHielo");
    }

    // M�todo que nos manda a la PantallaHieloIA si pulsamos el bot�n
    public void PantallaHieloIA()
    {
        SceneManager.LoadScene("PantallaHieloIA");
    }


}
