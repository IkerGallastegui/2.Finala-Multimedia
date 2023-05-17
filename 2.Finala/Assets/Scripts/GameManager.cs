using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pelota;

    public GameObject jugadorIzquierda;
    public GameObject jugadorIzquierdaGol;

    public GameObject jugadorDerecha;
    public GameObject jugadorDerechaGol;

    public Text jugadorIzquierdaTexto;
    public Text jugadorDerechaTexto;

    private int jugadorIzquierdaMarcador;
    private int jugadorDerechaMarcador;

    public bool IAPartida;

    // Markagailua 7-raino dela adierazten duen bariablea
    public int maxMarcador = 7;

    public void Victoria()
    {
        if(jugadorIzquierdaMarcador >= maxMarcador)
        {
            // Ezkerreko jokalaria irabazi duela agertzen da
            SceneManager.LoadScene("VictoriaJugadorIzquierda");
        }

        if(jugadorDerechaMarcador >= maxMarcador)
        {
            // Ezkuineko jokalaria irabazi duela agertzen da
            SceneManager.LoadScene("VictoriaJugadorDerecha");
        }
    }

    // Ezkerreko jokalariaren markagailua
    public void JugadorIzquierdaMarcador()
    {
        // Goiko baloreari bat gehitzen zaio
        jugadorIzquierdaMarcador++;
        // Int balorea String-era pasatu
        jugadorIzquierdaTexto.text = jugadorIzquierdaMarcador.ToString();
        Victoria();
        ResetPosition();
    }

    // Ezkuineko jokalariaren markagailua
    public void JugadorDerechaMarcador()
    {
        // Goiko baloreari bat gehitzen zaio
        jugadorDerechaMarcador++;
        // Int balorea String-era pasatu
        jugadorDerechaTexto.text = jugadorDerechaMarcador.ToString();
        Victoria();
        ResetPosition();
    }

    // Gola-ren ostean hasierako posiziora eramateko metodoa
    public void ResetPosition()
    {
        if(IAPartida)
        {
            // Pelota hasierako posizioan jarri
            pelota.GetComponent<Pelota>().Reset();
            // ezkuineko jokalaria hasierako posizioan jarri
            jugadorDerecha.GetComponent<Jugadores>().Reset();
        }
        else
        {
            // Pelota hasierako posizioan jarri
            pelota.GetComponent<Pelota>().Reset();
            // Ezkerreko jokalaria hasierako posizioan jarri
            jugadorIzquierda.GetComponent<Jugadores>().Reset();
            // ezkuineko jokalaria hasierako posizioan jarri
            jugadorDerecha.GetComponent<Jugadores>().Reset(); 
        }
    }
}
