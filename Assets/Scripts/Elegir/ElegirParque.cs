using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirParque : MonoBehaviour
{
    // M�todo para ir a la pantalla principal si pulsa 'Esc'
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }

    // M�todo que nos manda a la PantallaParque si pulsamos el bot�n
    public void PantallaParque()
    {
        SceneManager.LoadScene("PantallaParque");
    }

    // M�todo que nos manda a la PantallaParqueIA si pulsamos el bot�n
    public void PantallaParqueIA()
    {
        SceneManager.LoadScene("PantallaParqueIA");
    }


}
