using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirHierba : MonoBehaviour
{
    // M�todo para ir a la pantalla principal si pulsa 'Esc'
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }

    // M�todo que nos manda a la PantallaHierba si pulsamos el bot�n
    public void PantallaHierba()
    {
        SceneManager.LoadScene("PantallaHierba");
    }

    // M�todo que nos manda a la PantallaHierbaIA si pulsamos el bot�n
    public void PantallaHierbaIA()
    {
        SceneManager.LoadScene("PantallaHierbaIA");
    }


}
