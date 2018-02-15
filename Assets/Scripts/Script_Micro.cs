using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Script_Micro : MonoBehaviour {

    public Text texto;
    public Image imagen;

    private enum Estados{
        micro, micro_r, chofer, linterna, micro_linterna,
        micro_r_linterna, chofer_linterna, llave, ataque
    };

    Estados EstadoActual;
    
    void Start(){
        EstadoActual = Estados.micro;
        imagen = GameObject.Find("Panel").GetComponent<Image>();
    }
	
	void Update () {
        print(EstadoActual);
        if (EstadoActual == Estados.micro) {
            imagen.sprite = Resources.Load<Sprite>("Graphics/SilverDia");
            micro();
        }
        else if (EstadoActual == Estados.chofer) {
            imagen.sprite = Resources.Load<Sprite>("Graphics/SilverNoche");
            chofer(); }
        else if (EstadoActual == Estados.micro_r) {
            imagen.sprite = Resources.Load<Sprite>("Graphics/Tauren");
            micro_r(); }
        else if (EstadoActual == Estados.linterna) {
            imagen.sprite = Resources.Load<Sprite>("Graphics/Purga");
            linterna(); }
        else if (EstadoActual == Estados.micro_linterna) {
            imagen.sprite = Resources.Load<Sprite>("Graphics/PanSolido");
            micro_linterna(); }
        else if (EstadoActual == Estados.micro_r_linterna) {
            imagen.sprite = Resources.Load<Sprite>("Graphics/Bobafett");
            micro_r_linterna(); }
        else if (EstadoActual == Estados.chofer_linterna) {
            imagen.sprite = Resources.Load<Sprite>("Graphics/Chiste");
            chofer_linterna(); }
        else if (EstadoActual == Estados.llave) {
            imagen.sprite = Resources.Load<Sprite>("Graphics/Lali");
            llave(); }
        else if (EstadoActual == Estados.ataque) {
            imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
            ataque(); }
    }

    //Metodos de los estados
    void micro(){
        texto.text ="El micro se detiene a la mitad de la noche luego de un fuerte sonido, como una explosion.\n" +
                    "El chofer y vos bajan del vehiculo para averiguar que es lo que pasa. Humo sale de la parte trasera y " +
                    "el chofer se adelanta para ver que sucedio con una de las ruedas.\nRecuerdas que afortunadamente tienes tu" +
                    " linterna en el bolsillo.\n\n" +
                    "Presiona C para hablar con el Chofer, L para Linterna, M para inspeccionar el Micro";
        if (Input.GetKeyDown(KeyCode.C)) { EstadoActual = Estados.chofer; }
        else if (Input.GetKeyDown(KeyCode.M)) { EstadoActual = Estados.micro_r; }
        else if (Input.GetKeyDown(KeyCode.L)) { EstadoActual = Estados.linterna; }
    }

    void chofer(){
        texto.text ="Te acercas al chofer y lo observas agarrandose la cabeza. Una cubierta reventada.\n" +
                    "Le preguntas como piensa solucionar " +
                    "esta situacion, a lo que el te contesta: \n-No tengo la herramienta para el trabajo. \nToda tu esperanza " +
                    "se desvanece por un momento.\n\n" +
                    "Presiona V para Volver";
        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro; }
    }

    void micro_r(){
        texto.text ="Un agujero en el canio de escape, seguramente producido por el golpe que sufrimos, hizo que humo se " +
                    "concentrara en la parte trasera del vehiculo. No crees poder hacer nada al respecto.\n" +
                    "Es dificil respirar aqui.\n\n" +
                    "Presiona V para Volver";
        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro; }
    }

    void linterna()
    {
        texto.text ="Sacas tu confiable linterna de bolsillo.\nLED, alcance de 80 metros e intensidad regulable, con solo 3 pilas AAA" +
                    " para darte una duracion de casi 30 horas. De todos modos, debo usar el tiempo con sabiduria.\n\n" +
                    "Presiona V para Volver, E para Encender la linterna";
        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro; }
        else if (Input.GetKeyDown(KeyCode.E)) { EstadoActual = Estados.micro_linterna; }
    }

    void micro_linterna()
    {
        texto.text = "Bueno, el micro sigue humeando, inclinado y parado. El chofer sigue sin hacer nada, mas que agarrarse la cabeza y " +
                    "mirarte un tanto extraniado.\nTodo esto bajo la luz de tu hermosa linterna. No sabes exactamente que estas " +
                    "haciendo, pero te pones serio ya que la gente dentro del micro te observa.\nEn un rapido vistazo, ves un brillo " +
                    "al costado del camino.\n\n" +
                    "Presiona C para hablar con el Chofer, A para Acercarte al objeto brilloso, M para inspeccionar el Micro";
        if (Input.GetKeyDown(KeyCode.C)) { EstadoActual = Estados.chofer_linterna; }
        else if (Input.GetKeyDown(KeyCode.A)) { EstadoActual = Estados.llave; }
        else if (Input.GetKeyDown(KeyCode.M)) { EstadoActual = Estados.micro_r_linterna; }
    }
    void micro_r_linterna()
    {
        texto.text = "El humo se ha disipado un poco, aunque aun es dificultoso respirar.\nCon esta claridad, puedes ver como el canio de " +
                    "escape del vehiculo esta doblado, probablemente por el golpe que sufrio contra la banquina. Es reparable, pero no sin " +
                    "hacer ruido, mas del que ya hemos hecho.\n\n" +
                    "Presiona V para Volver";
        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro_linterna; }
    }

    void chofer_linterna()
    {
        texto.text = "Ahora puedes ver como el chofer se lamenta pero con una claridad que antes no podias imaginar. Realmente " +
                    "la tecnologia LED tiene mucho que ofrecer. Escuchas que el chofer murmulla algo, una cancion tal vez...\n\n" +
                    "Presiona V para Volver";
        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro_linterna; }
    }

    void llave()
    {
        texto.text = "Al acercarte, oyes extranios ruidos provenientes del bosque. Lo que brilla, parece ser un objeto metalico, " +
                    "sobresaliendo del suelo del barranco. Al inspeccionarlo de cerca, parece una especie de herramienta...\n\n" +
                    "Presiona V para Volver, A para Agarrar el objeto";
        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro_linterna; }
        else if (Input.GetKeyDown(KeyCode.A)) { EstadoActual = Estados.ataque; }
    }

    void ataque()
    {
        texto.text = "Al comenzar a desenterrar el objeto metalico, pegas un grito llamando al Chofer para que te cubra la espalda.\n" +
        "Cuando este se acerca para ver que estas haciendo, reconoce que el objeto es, sin lugar a dudas, la herramienta " +
        "que necesita para repara el vehiculo.\nPero no cantemos victoria, puedo ver como los muertos corren hacia nosotros...\n\n" +
        "Presiona J para Jugar de nuevo.";
        if (Input.GetKeyDown(KeyCode.J)) { EstadoActual = Estados.micro; }
    }

}
