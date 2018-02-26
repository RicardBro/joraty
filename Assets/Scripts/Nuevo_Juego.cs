using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nuevo_Juego : MonoBehaviour {

    public void PlayScene() {
        SceneManager.LoadScene("Escenario-MicroAveriado");
    }
}
