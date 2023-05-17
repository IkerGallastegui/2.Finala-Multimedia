using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoriaEscena : MonoBehaviour
{
    void Start()
    {
        // Hiru segundu iraugo du eszena hau
        Invoke("RecargaMenu",3);
    }

    public void RecargaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
