using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScriptBola : MonoBehaviour
{

    //Variables del juego
    Rigidbody2D rb;
    bool enPartida;
    public static int vidas = 5;
    int puntuacion = 0;
    public static int numeroBolas = 0;
    //Variables de texto
    public Text textoVidas;
    public Text textoPuntuacion;

    //Variables barrita
    public Transform barrita;
    public static float velocidadSalida = 500f;
    public static Transform trBola;
    public static Rigidbody2D rbBola;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        textoVidas.text = vidas.ToString();
        rbBola = rb;
    }

        // Update is called once per frame
    void Update()
        {
        if (!enPartida) {

            transform.position = barrita.position + new Vector3(0, 1, 0);
            Time.timeScale = 0f;

        }
        if (Input.GetButtonDown("Jump")&& !enPartida){
            enPartida = true;
            Time.timeScale = 1f;
            rb.AddForce(Vector2.up * velocidadSalida);
            trBola = transform;
        }
        textoVidas.text = vidas.ToString();
        if (vidas <= 0)
        {
            textoVidas.text = "GAME OVER";
            textoPuntuacion.text = "GAME OVER";
            Time.timeScale = 0f;
            Debug.Log("Game Over");
        }
        numeroBolas =
        Debug.Log(numeroBolas);
    }
    //Para acabar la partida si la bola se sale
    void OnTriggerEnter2D(Collider2D conElQueChocas){
        if (conElQueChocas.CompareTag("Finish"))

            if(numeroBolas <= 0)
            {

                rb.velocity = Vector2.zero;

                enPartida = false;

                vidas = vidas - 1;

                textoVidas.text = "" + vidas;

            }



    }




}

