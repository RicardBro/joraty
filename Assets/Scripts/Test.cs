using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

    public Text texto;
    public Image imagen;

    private enum Estados
    {
        micro, micro_r, chofer, linterna, micro_linterna,
        micro_r_linterna, chofer_linterna, llave, ataque
    }

    Estados EstadoActual;

    // Use this for initialization
    void Start () {
        EstadoActual = Estados.micro;
    }
	
	// Update is called once per frame
	void Update ()
    {
        print(EstadoActual);
       /* switch (EstadoActual)
        {
            case (Estados.micro):
                imagen.sprite = Resources.Load<Sprite>("Graphics/Micro");
                Micro();
                break;

            case (Estados.micro_r):
                imagen.sprite = Resources.Load<Sprite>("Graphics/Tauren");
                Micro_r();
                break;

            case (Estados.chofer):
                imagen.sprite = Resources.Load<Sprite>("Graphics/SilverNoche");
                Chofer();
                break;

            case (Estados.linterna):
                imagen.sprite = Resources.Load<Sprite>("Graphics/Purga");
                linterna();
                break;
            case (Estados.micro_linterna):
                imagen.sprite = Resources.Load<Sprite>("Graphics/PanSolido");
                micro_linterna();
                break;
            case (Estados.micro_r_linterna):
                imagen.sprite = Resources.Load<Sprite>("Graphics/Bobafett");
                micro_r_linterna();
                break;
            case (Estados.chofer_linterna):
                imagen.sprite = Resources.Load<Sprite>("Graphics/Chiste");
                chofer_linterna();
                break;
            case (Estados.llave):
                imagen.sprite = Resources.Load<Sprite>("Graphics/Lali");
                llave();
                break;
            case (Estados.ataque):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                ataque();
                break;
        }*/
    }
    void Micro()
    {
        texto.text = "El micro se detiene a la mitad de la noche luego de un fuerte sonido, como una explosion.\n" +
                    "El chofer y vos bajan del vehiculo para averiguar que es lo que pasa. Humo sale de la parte trasera y " +
                    "el chofer se adelanta para ver que sucedio con una de las ruedas.\nRecuerdas que afortunadamente tienes tu" +
                    " linterna en el bolsillo.\n\n" +
                    "Presiona C para hablar con el Chofer, L para Linterna, M para inspeccionar el Micro";
        if (Input.GetKeyDown(KeyCode.C)) { EstadoActual = Estados.chofer; }
        else if (Input.GetKeyDown(KeyCode.M)) { EstadoActual = Estados.micro_r; }
        else if (Input.GetKeyDown(KeyCode.L)) { EstadoActual = Estados.linterna; }
    }

    void Chofer()
    {
        texto.text = "Te acercas al chofer y lo observas agarrandose la cabeza. Una cubierta reventada.\n" +
                    "Le preguntas como piensa solucionar " +
                    "esta situacion, a lo que el te contesta: \n-No tengo la herramienta para el trabajo. \nToda tu esperanza " +
                    "se desvanece por un momento.\n\n" +
                    "Presiona V para Volver";
        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro; }
    }

    void Micro_r()
    {
        texto.text = "Un agujero en el canio de escape, seguramente producido por el golpe que sufrimos, hizo que humo se " +
                    "concentrara en la parte trasera del vehiculo. No crees poder hacer nada al respecto.\n" +
                    "Es dificil respirar aqui.\n\n" +
                    "Presiona V para Volver";
        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro; }
    }
}
