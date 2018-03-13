using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Script_Micro : MonoBehaviour
{

    public Text texto;
    public Image imagen;

    private enum Estados
    {
        micro, micro_r, chofer, linterna, micro_linterna,
        micro_r_linterna, chofer_linterna, llave, ataque,
        defensa, ggchofer, hombres, mandarse, mandarsefull,
        hombresfull, choferfull, mandados, chofermandados, atacando, choferatacando
    }

    Estados EstadoActual;
    
    void Start(){
        EstadoActual = Estados.micro;
        imagen = GameObject.Find("Panel").GetComponent<Image>();
    }
	
	void Update ()
    {
        print(EstadoActual);

        switch (EstadoActual)
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
                Linterna();
                break;

            case (Estados.micro_linterna):
                imagen.sprite = Resources.Load<Sprite>("Graphics/PanSolido");
                Micro_linterna();
                break;

            case (Estados.micro_r_linterna):
                imagen.sprite = Resources.Load<Sprite>("Graphics/Bobafett");
                Micro_r_linterna();
                break;

            case (Estados.chofer_linterna):
                imagen.sprite = Resources.Load<Sprite>("Graphics/Chiste");
                Chofer_linterna();
                break;

            case (Estados.llave):
                imagen.sprite = Resources.Load<Sprite>("Graphics/Lali");
                Llave();
                break;

            case (Estados.ataque):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                Ataque();
                break;
            //*****
            case (Estados.defensa):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                Defensa();
                break;
            case (Estados.ggchofer):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                Ggchofer();
                break;
            case (Estados.hombres):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                Hombres();
                break;
            case (Estados.mandarse):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                Mandarse();
                break;
            case (Estados.mandarsefull):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                Mandarsefull();
                break;
            case (Estados.choferfull):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                Choferfull();
                break;
            case (Estados.hombresfull):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                Hombresfull();
                break;
            case (Estados.mandados):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                Mandados();
                break;
            case (Estados.chofermandados):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                Chofermandados();
                break;
            case (Estados.atacando):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                Atacando();
                break;
            case (Estados.choferatacando):
                imagen.sprite = Resources.Load<Sprite>("Graphics/TronoHelado");
                Choferatacando();
                break;
        }
    }

    //Metodos de los estados
    void Micro(){
        texto.text ="El micro se detiene a la mitad de la noche luego de un fuerte sonido, como una explosion.\n" +
                    "El chofer y vos bajan del vehiculo para averiguar que es lo que pasa. Humo sale de la parte trasera y " +
                    "el chofer se adelanta para ver que sucedio con una de las ruedas.\nRecuerdas que afortunadamente tienes tu" +
                    " linterna en el bolsillo.\n\n" +
                    "Presiona C para hablar con el Chofer, L para Linterna, M para inspeccionar el Micro";

        if (Input.GetKeyDown(KeyCode.C)) { EstadoActual = Estados.chofer; }
        else if (Input.GetKeyDown(KeyCode.M)) { EstadoActual = Estados.micro_r; }
        else if (Input.GetKeyDown(KeyCode.L)) { EstadoActual = Estados.linterna; }
    }

    void Chofer(){
        texto.text ="Te acercas al chofer y lo observas agarrandose la cabeza. Una cubierta reventada.\n" +
                    "Le preguntas como piensa solucionar " +
                    "esta situacion, a lo que el te contesta: \n-No tengo la herramienta para el trabajo. \nToda tu esperanza " +
                    "se desvanece por un momento.\n\n" +
                    "Presiona V para Volver";

        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro; }
    }

    void Micro_r(){
        texto.text ="Un agujero en el canio de escape, seguramente producido por el golpe que sufrimos, hizo que humo se " +
                    "concentrara en la parte trasera del vehiculo. No crees poder hacer nada al respecto.\n" +
                    "Es dificil respirar aqui.\n\n" +
                    "Presiona V para Volver";

        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro; }
    }

    void Linterna()
    {
        texto.text ="Sacas tu confiable linterna de bolsillo.\nLED, alcance de 80 metros e intensidad regulable, con solo 3 pilas AAA" +
                    " para darte una duracion de casi 30 horas. De todos modos, debo usar el tiempo con sabiduria.\n\n" +
                    "Presiona V para Volver, E para Encender la linterna";

        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro; }
        else if (Input.GetKeyDown(KeyCode.E)) { EstadoActual = Estados.micro_linterna; }
    }

    void Micro_linterna()
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
    void Micro_r_linterna()
    {
        texto.text = "El humo se ha disipado un poco, aunque aun es dificultoso respirar.\nCon esta claridad, puedes ver como el canio de " +
                    "escape del vehiculo esta doblado, probablemente por el golpe que sufrio contra la banquina. Es reparable, pero no sin " +
                    "hacer ruido, mas del que ya hemos hecho.\n\n" +
                    "Presiona V para Volver";

        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro_linterna; }
    }

    void Chofer_linterna()
    {
        texto.text = "Ahora puedes ver como el chofer se lamenta pero con una claridad que antes no podias imaginar. Realmente " +
                    "la tecnologia LED tiene mucho que ofrecer. Escuchas que el chofer murmulla algo, una cancion tal vez...\n\n" +
                    "Presiona V para Volver";

        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro_linterna; }
    }

    void Llave()
    {
        texto.text = "Al acercarte, oyes extranios ruidos provenientes del bosque. Lo que brilla, parece ser un objeto metalico, " +
                    "sobresaliendo del suelo del barranco. Al inspeccionarlo de cerca, parece una especie de herramienta...\n\n" +
                    "Presiona V para Volver, A para Agarrar el objeto";

        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.micro_linterna; }
        else if (Input.GetKeyDown(KeyCode.A)) { EstadoActual = Estados.ataque; }
    }

    void Ataque()
    {
        texto.text = "Al comenzar a desenterrar el objeto metalico, pegas un grito llamando al Chofer para que te cubra la espalda.\n" +
        "Cuando este se acerca para ver que estas haciendo, reconoce que el objeto es, sin lugar a dudas, la herramienta " +
        "que necesita para repara el vehiculo.\nPero no cantemos victoria, puedo ver como los muertos corren hacia nosotros...\n" +
        "Presiona D para comenzar la defensa contra los muertos!.";

        if (Input.GetKeyDown(KeyCode.D)) { EstadoActual = Estados.defensa; }
    }
    //*******
    void Defensa()
    {
        texto.text = "El chofer se apresura a cambiar la cubierta rota, mientras vos y un grupo de otros 3 hombres, \n " +
                      "armados con palas y algunos palos, se preparan a defender el micro. \n " +
                      "Desde el bosque se puede observar un grupo de 4 muertos, casi todos completos. Uno de ellos tiene un bigote imponente. \n" +
                      "Presiona H para hablar con el Chofer, G para hablar con los tipos, M para Mandarse";

        if (Input.GetKeyDown(KeyCode.H)) { EstadoActual = Estados.ggchofer; }
        else if (Input.GetKeyDown(KeyCode.G)) { EstadoActual = Estados.hombres; }
        else if (Input.GetKeyDown(KeyCode.M)) { EstadoActual = Estados.mandarse; }

    }

    void Ggchofer()
    {
        texto.text = "El chofer no consigue decir una palabra, mientras, sentado, respira agitadamente y saca las tuercas de la rueda del micro. \n " +
                     "Le comentas, brevemente, sobre los beneficios de los ejercicios cardiovasculares. \n"+
                     "Presiona V para volver";

        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.defensa; }
        
    }

    void Hombres()
    {
        texto.text = "Te diriges al grupo de hombres para preguntar si, en el tiempo que tuvieron dentro del micro, pensaron algún tipo de plan. \n" +
                     "A lo que te contesta el menos confundido de los 4: \n" +
                     "Correr hacia ellos y golpearlos con estas ‘Herramientas’ que encontramos por ahí(Mientras señala el costado de un auto en ruinas) \n" +
                     "Por un momento tu fe en que van a morir se renueva. \n" +
                     "Presiona V para volver";

        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.defensa; }

    }

    void Mandarse()
    {
        texto.text = "Reunes todo tu valor, y armado  con una pala de mano que te alcanzo un compañero y tu linterna, te adelantas unos pasos hacia el grupo de  muertos. \n" +
                     "Los hombres que te acompañan te miran extrañados, no sabiendo qué hacer y remitiéndose a mantener la posición.\n" +
                     "El chofer tiene un extraño color blanco/amarillo en su rostro... \n" +
                     "Presiona V para volver, M para ir con todo";

        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.defensa; }
        else if (Input.GetKeyDown(KeyCode.M)) { EstadoActual = Estados.mandarsefull; }
    }

    void Mandarsefull()
    {
        texto.text = "En un momento de furia, instinto protector e inconciencia temporal, te adelantas hasta casi alcanzar a uno de los muertos \n" +
                     "(En vida una señora mayor, que sostiene en su mano un martillo para ablandar carne). \n" +
                     "El grupo de hombre a tus espaldas grita cosas indescifrables, y en tu estado de locura, solo son un murmullo en las tinieblas. \n" +
                     "Tu visión panorámica se encuentra reducida considerablemente. \n" +
                     "Presiona H para hablar con el Chofer, C para hablar con los tipos";
        
        if (Input.GetKeyDown(KeyCode.H)) { EstadoActual = Estados.choferfull; }
        else if (Input.GetKeyDown(KeyCode.C)) { EstadoActual = Estados.hombresfull; }

    }

    void Choferfull()
    {
        texto.text = "falta texto";

        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.mandarsefull; }
        
    }

    void Hombresfull()
    {
        texto.text = "falta texto";
        if (Input.GetKeyDown(KeyCode.D)) { EstadoActual = Estados.mandados; }
        else if (Input.GetKeyDown(KeyCode.A)) { EstadoActual = Estados.atacando; }
   
    }

    void Mandados()
    {
        texto.text = "falta texto";
        if (Input.GetKeyDown(KeyCode.H)) { EstadoActual = Estados.chofermandados; }
        else if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.hombresfull; }
    }

    void Chofermandados()
    {
        texto.text = "falta texto";
        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.mandados; }
    }

    void Atacando()
    {
        texto.text = "falta texto";
        if (Input.GetKeyDown(KeyCode.V)) { EstadoActual = Estados.hombresfull; }
        else if (Input.GetKeyDown(KeyCode.A)) { EstadoActual = Estados.choferatacando; }
    }

    void Choferatacando()
    {
        texto.text = "falta texto";
        //texto del final
    }





}
