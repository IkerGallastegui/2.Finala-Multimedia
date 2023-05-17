using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    // Inteligentzia artifizialaren abiadura
    public float v = 3;

    // Pelotaren erreferentzia
    public GameObject pelota;

    // Pelotaren posizioa
    private Vector2 pelotaP;

    void Update()
    {
        // Behean dagoen metodoa exekutatu
        Mover();
    }

    void Mover()
    {
        pelotaP = pelota.transform.position;

        // Gure y posizioa pelotaren y posizioa handiagoa bada if-ean sartzen da
        if(transform.position.y > pelotaP.y)
        {
            // Gure posizioa handiagoa denez pelotaren posizioa baino behera eramaten du jokalaria
            transform.position += new Vector3(0, -v*Time.deltaTime);
        }

        // Gure y posizioa pelotaren y posizioa txikiagoa bada if-ean sartzen da
        if (transform.position.y < pelotaP.y)
        {
            // Gure posizioa txikiagoa denez pelotaren posizioa baino gora eramaten du jokalaria
            transform.position += new Vector3(0, v*Time.deltaTime);
        }
    }
}
