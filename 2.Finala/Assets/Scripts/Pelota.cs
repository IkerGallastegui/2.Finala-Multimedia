using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    // Pelotaren mugimendua adierazteko balorea
    public float v = 7;
    // Pelota norabide guztietan mugitzeko konponentea
    public Rigidbody2D rb;

    // Hasierako posizioa adierazteko bariablea
    private Vector2 pi;

    void Start()
    {
        // Pelotaren hasierako pisizioa
        pi = transform.position;
        // Behean deitu diodan programa hemen exekutatu
        Launch();
    }

    public void Reset()
    {
        // Jokalariak zero posizioan jarriko dira
        rb.velocity = Vector2.zero;
        transform.position = pi;
        // Pelotaren programa berriro exekutatu
        Launch();
    }

    public void Launch()
    {
        // Pelotaren hasierako mugimendua x ardatzean aleatorioki izatea
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        // Pelotaren hasierako mugimendua y ardatzean aleatorioki izatea
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        // Pelotaren abiadura
        rb.velocity = new Vector2(v * x, v * y);
    }
}
