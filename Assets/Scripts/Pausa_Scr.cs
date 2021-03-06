﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pausa_Scr : MonoBehaviour {

    bool Activar;
    Canvas Pausa;
    Script_Micro src_historia;

	// Use this for initialization
	void Start () {
        Pausa = GetComponent<Canvas>();
        Pausa.enabled = false;
        src_historia = GameObject.Find("Historia").GetComponent<Script_Micro>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape")) {
            Activar = !Activar;
            Pausa.enabled = Activar;
        }
        if (Activar == true) {
            src_historia.enabled = false;
        }
        else if (Activar == false) {
            src_historia.enabled = true;
        }
    
	}

    public void Menu()
    {
        GetComponent<AudioSource>().Play();
        Invoke("MenuPrincipal", GetComponent<AudioSource>().clip.length);
    }

    public void Quit()
    {
        GetComponent<AudioSource>().Play();
        Invoke("Salir", GetComponent<AudioSource>().clip.length);
    }

    //Metodos de funciones

    void MenuPrincipal()
    {
        SceneManager.LoadScene("Escenario-MenuPrincpal");
    }
    void Salir()
    {
        Application.Quit();
    }
}


