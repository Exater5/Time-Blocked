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
    bool activado = false;
    bool pulso = false;
    // Start is called before the first frame update
    void Start()
    {

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
            Time.timeScale = 1f;
        }
        else
        {
            animPanelPausa.SetBool("Sales", false);
            Time.timeScale = 0f;
            animAjustes.SetBool("Sales", false);
        }
    }


    //Funciones de carga de Escenas
    public void CargaMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void CargaNivel()
    {
        SceneManager.LoadScene(1);
    }
    public void CargaNivel2()
    {
        SceneManager.LoadScene(2);
    }
    public void CargaNivel3()
    {
        SceneManager.LoadScene(3);
    }
    public void CargaNivel4()
    {
        SceneManager.LoadScene(4);
    }
}
