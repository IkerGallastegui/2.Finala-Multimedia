using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void JugadorVSIA()
    {
        SceneManager.LoadScene("JugadorVSIA");
    }

    public void JugadorVSJugador()
    {
        SceneManager.LoadScene("JugadorVSJugador");
    }
}
