using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirNormal : MonoBehaviour
{
    // M�todo para ir a la pantalla principal si pulsa 'Esc'
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }

    // M�todo que nos manda a la PantallaNormal si pulsamos el bot�n
    public void PantallaNormal()
    {
        SceneManager.LoadScene("PantallaNormal");
    }

    // M�todo que nos manda a la PantallaNormalIA si pulsamos el bot�n
    public void PantallaNormalIA()
    {
        SceneManager.LoadScene("PantallaNormalIA");
    }


}
