using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuentaBloques : MonoBehaviour
{
    public Animator animacionGanar;
    public float tiempo;
    bool jugando = true;
    public Text contador;
    public Text textoFinal;
    // Start is called before the first frame update
    void Start()
    {
        contador.text = "00";
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount <= 0 && jugando == true)
        {
            TerminaPartida();
            jugando = false;
        }
        tiempo = Time.time;
        contador.text = Mathf.Round(tiempo).ToString();
    }
    void TerminaPartida()
    {
        textoFinal.text = ("Bieeen, has tardado " + Mathf.Round(tiempo) + " segundos en superar el mapa");
        animacionGanar.SetTrigger("pierdes");
        Time.timeScale = 0f;
    }
}
