using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public Animator animAjustes;
    public Animator animMundos;
    public Animator animFondo;
    public Animator animPanelPausa;
    public Animator persiana;
	public float tiempoAnimacion = 1.5f;
	public string nombreNivel = "CargaNivel";
    bool activado = false;
    bool pulso = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {

    }


    //Funciones Menu de Inicio

    public void BotonInicio()
    {
        animMundos.SetTrigger("PulsarBotonInicio");
        animFondo.SetTrigger("Mapas");
        Debug.Log("Boton Inicio");

    }
    public void BotonAtras()
    {
        animMundos.SetTrigger("PulsarBotonAtras");
        animFondo.SetTrigger("Menu");
    }


    //Funciones Menu de Pausa
    public void Ajustes()
    {
        activado = !activado;
        if(activado == true)
        {
            animAjustes.SetBool("Sales", true);
        }
        else
        {
            animAjustes.SetBool("Sales", false);
        }
        
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void Pausa()
    {
        pulso = !pulso;
        if (pulso == true)
        {
            animPanelPausa.SetBool("Sales", true);
            Time.timeScale = 0f;
        }
        else
        {
            animPanelPausa.SetBool("Sales", false);
            Time.timeScale = 1f;
            animAjustes.SetBool("Sales", false);
        }
    }

    //Retraso del cambio de escena y animación persiana.

   
    
    public void ActivaPersiana()
    {

    	persiana.SetTrigger("Baja");
        Invoke("CargaNivel", tiempoAnimacion);

    }
    public  void ActivaPersiana2()
    {

    	persiana.SetTrigger("Baja");
        Invoke("CargaNivel2", tiempoAnimacion);

    }
    public  void ActivaPersiana3()
    {

    	persiana.SetTrigger("Baja");
        Invoke("CargaNivel3", tiempoAnimacion);

    }
    public  void ActivaPersiana4()
    {

    	persiana.SetTrigger("Baja");
        Invoke("CargaNivel4", tiempoAnimacion);

    }
    public  void ActivaPersiana5()
    {

    	persiana.SetTrigger("Baja");
        Invoke("CargaNivel5", tiempoAnimacion);

    }


    //Funciones de carga de Escenas
    public void CargaMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void CargaNivel()
    {
        SceneManager.LoadScene(1);
        ListaBolas.vidas = 3;
    }
    public void CargaNivel2()
    {
        SceneManager.LoadScene(2);
        ListaBolas.vidas = 3;
    }
    public void CargaNivel3()
    {
        SceneManager.LoadScene(3);
        ListaBolas.vidas = 3;
    }
    public void CargaNivel4()
    {
        SceneManager.LoadScene(4);
        ListaBolas.vidas = 3;
    }
    public void CargaNivel5()
    {
        SceneManager.LoadScene(5);
        ListaBolas.vidas = 3;
    }
    public void CargaCreditos()
    {
        SceneManager.LoadScene(6);
    }
}
