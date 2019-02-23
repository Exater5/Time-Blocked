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
    public GameObject todosLosObjetos;
    public Button botonSigNivel;
    public int numeroDeMundo;
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
            Destroy(todosLosObjetos);
        }
        tiempo = Time.time;
        contador.text = Mathf.Round(tiempo).ToString();
    }
    void TerminaPartida()
    {
        textoFinal.text = ("Enhorabuena, has completado el Nivel " + (numeroDeMundo +1)  +" en " + Mathf.Round(tiempo) + " segundos");
        if (numeroDeMundo > PlayerPrefs.GetInt("Niveles"))
        {
            GuardaProgreso.SumaNivel();
        }
       
        Debug.Log("He sumado un nivel");
        animacionGanar.SetTrigger("pierdes");
        Time.timeScale = 0f;
        botonSigNivel.interactable = true;
    }
}
