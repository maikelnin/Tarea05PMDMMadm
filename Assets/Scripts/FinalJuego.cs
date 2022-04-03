using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalJuego : MonoBehaviour
{
    // M�todo que invoca a CargarMenuPrincipal a los 6 segundos
    void Start()
    {
        Invoke("CargarMenuPrincipal", 6);
    }

    // M�todo para ir a la escena MenuPrincipal
    public void CargarMenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
