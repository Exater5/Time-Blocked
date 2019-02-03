using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaquinaTiempo : MonoBehaviour
{
    public static bool prehistoria = false;

    //Tiempo
    public float tiempoActual;
    public float tiempoFixed;
    public Text temporizador;
    //Variables Barra
    public SpriteRenderer srActualBarra;
    public Sprite spritePBarra;
    public Sprite spriteFBarra;

    //Variables Bola
   
    public Sprite spritePBola;
    public Sprite spriteFBola;

    //Variables fondo
    public Image actualFondo;
    public Sprite spritePFondo;
    public Sprite spriteFFondo;
    public Animator animGameOver;
    public Text textoPersiana;
    public Animator animacionFondos;
    public Animator RelojS2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (prehistoria == false)
        {
            //tiempoActual = Mathf.Round( Time.time * 10) / 10;
            tiempoActual += Time.deltaTime;
            tiempoFixed = Mathf.Round(tiempoActual * 10) / 10;

            temporizador.text = tiempoFixed.ToString();

        }
        else
        {
            tiempoActual -= Time.deltaTime;
            tiempoFixed = Mathf.Round(tiempoActual * 10) / 10;

            temporizador.text = tiempoFixed.ToString();
        }

        if( tiempoFixed < 0)
        {
            GameOver();

        }
    }
    public void ViajeTemporal()
    {
        prehistoria = !prehistoria;
        


        
        if(prehistoria == true)
        {
            srActualBarra.sprite = spritePBarra;
            animacionFondos.SetTrigger("ViajePasado");
            RelojS2.SetTrigger("ViajeTemporal");
        }
        else
        {
            srActualBarra.sprite = spriteFBarra;
            animacionFondos.SetTrigger("ViajeFuturo");
            RelojS2.SetTrigger("ViajeTemporal");
        }
    }
    void GameOver()
    {
        temporizador.text = "Game Over";
        Time.timeScale = 0f;
        animGameOver.SetTrigger("pierdes");
        textoPersiana.text = "Game Over";
        prehistoria = false;
    }
}
