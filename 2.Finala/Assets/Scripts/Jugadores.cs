using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugadores : MonoBehaviour
{

    public bool jugadorizquierda;
    // Jokalariaren mugimendua adierazteko balorea
    public float v = 3;
    // Jokalaria gora eta behera mugitzeko konponentea
    public Rigidbody2D rb;

    // Mugimendua adierazteko bariablea
    private float m;
    // Hasierako posizioa adierazteko bariablea
    private Vector2 pi;

    private float moveSpeedTouchControl = 0.05f;

    void Start()
    {
        // Jokalarien hasierako pisizioa
        pi = transform.position;
    }

    void Update()
    {
        // Ezkerreko jokalaria izaten bada if-ean sartzen da eta bestela ezkuineko jokalaria izango da eta else-an sartuko da
        if(jugadorizquierda)
        {
            if(Input.GetMouseButton(0))
            {
                Vector3 ratonP = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if(ratonP.x < -1)
                {
                    if(ratonP.y > 0.5)
                    {
                        transform.Translate(0, moveSpeedTouchControl, 0);
                    }
                    else if(ratonP.y < -0.5)
                    {
                        transform.Translate(0, -moveSpeedTouchControl, 0);
                    }
                }
            }

            // Ezkerreko jokalaria mugitu ahal izateko
            m = Input.GetAxisRaw("JugadorIzquierda");
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 ratonP = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if (ratonP.x > 1)
                {
                    if (ratonP.y > 0.5)
                    {
                        transform.Translate(0, moveSpeedTouchControl, 0);
                    }
                    else if (ratonP.y < -0.5)
                    {
                        transform.Translate(0, -moveSpeedTouchControl, 0);
                    }
                }
            }

            // Ezkuineko jokalaria mugitu ahal izateko
            m = Input.GetAxisRaw("JugadorDerecha");
        }

        // Jokalarien abiadura
        rb.velocity = new Vector2(rb.velocity.x, m*v);

    }

    // Jokalariak eta pelota hasierako posiziora joango dira puntu bat sartu eta gero
    public void Reset()
    {
        // Jokalariak zero posizioan jarriko dira
        rb.velocity = Vector2.zero;
        transform.position = pi;
    }
}
