using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour {
    
    public void PlayScene() {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Escenario-MicroAveriado");
    }

    public void Cargar()
    {
        GetComponent<AudioSource>().Play();
        //Application.Quit();
    }

    public void Opciones()
    {
        GetComponent<AudioSource>().Play();
        //Application.Quit();
    }

    public void Quit()
    {
        GetComponent<AudioSource>().Play();
        Application.Quit();
    }
}
