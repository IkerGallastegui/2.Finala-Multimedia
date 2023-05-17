using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool jugadorIzquierdaGol;
    public GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Pelota"))
        {
            if(jugadorIzquierdaGol)
            {
                gameManager.GetComponent<GameManager>().JugadorIzquierdaMarcador();
            }
            else
            {
                gameManager.GetComponent<GameManager>().JugadorDerechaMarcador();
            }
        }
    }
}
