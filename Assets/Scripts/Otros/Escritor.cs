using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//importante llamar a la librería de TextMeshPro ((si no no van a aparecer las variables))
[RequireComponent(typeof(TextMeshProUGUI))] /*Aquí estamos obligando al objeto que lleve el script a tener
como componente el TextMeshProUGUI, de hecho, si pruebas a eliminárselo, no te deja*/
public class Escritor : MonoBehaviour
{
    string textoQueEscribo;   //Aquí va el texto que se va a escribir
    TextMeshProUGUI textoMesh; //Este es el soporte en el que se va a escribir
    int indice = 0; /*Este número hará referencia a la letra del texto que se va a escribir, empezando por el 0,
    es decir, de la palabra VACA, la letra 0 será la V, la 1 será la A...*/
    float tiempoInicio;
    float tiempoActual;
    public float velocidadDeEscritura = 0.1f; //Tiempo que va a tardar entre que escribe una letra y otra

    // Start is called before the first frame update
    void Start()
    {
        textoMesh = GetComponent<TextMeshProUGUI>(); //Le cogemos el componente del texto al gameObject que tiene el script
        textoQueEscribo = textoMesh.text; /*Aqui le decimos que la variable de tipo string (textoQueEscribo) que hemos hecho va a conterner
        el texto que hemos añadido desde el editor al componente TextMeshPro*/
        textoMesh.text = ""; /*Ahora le decimos que el texto del textMesh esté vacío para que no salga nada en pantalla y
        para guardar el texto que había antes se lo hemos pasado a la variable textoQueEscribo*/
        tiempoInicio = Time.time;  //el tiempo de inicio va a ser el tiempo actual del juego, es decir 0, porque acaba de empezar. 
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        tiempoActual = Time.time; //Cada frame actualiza el tiempo actual
        if(tiempoActual> tiempoInicio + velocidadDeEscritura) //Esto se sobreentiende xddd
        {
            EscribeLetra(textoQueEscribo[indice]); /*Aquí estamos ejecutando una funcion de tipo char, es decir, solo
            le caben caracteres, por lo que si le pasamos un string, solo va a coger la letra que le digamos, que es indice*/

            ++indice; //Sumamos uno a indice para que la siguiente vez que se ejecute escriba la siguiente letra

            tiempoInicio = tiempoActual; //Aqui le decimos que vuelva a contar el tiempo pero desde el momento exacto en el que se ha ejecutado
        }

    }
    public void EscribeLetra(char letraAEscribir)
    {
        textoMesh.text = textoMesh.text + letraAEscribir; //En esta funcion solo nos sumará una letra a nuestro texto. 
    }
}
