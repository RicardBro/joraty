using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{

    public void PlayScene(){
        GetComponent<AudioSource>().Play();
        Invoke("Nuevojuego", GetComponent<AudioSource>().clip.length);   
    }

        void Nuevojuego(){
            SceneManager.LoadScene("Escenario-MicroAveriado");
        }

    public void Opciones(){
        GetComponent<AudioSource>().Play();
        //Application.Quit();
    }

    public void Quit(){
        GetComponent<AudioSource>().Play();
        Invoke("Salir", GetComponent<AudioSource>().clip.length);
    }
        void Salir(){
            Application.Quit();
        }
}