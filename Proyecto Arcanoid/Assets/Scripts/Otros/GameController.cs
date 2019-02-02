using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public Animator animMenu;
    public Animator animMundos;
    public Animator animFondo;
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
    public void Continuar()
    {
        animMenu.SetBool("Sales", false);
        Time.timeScale = 1f;
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void Pausa()
    {
        animMenu.SetBool("Sales", true);
        Time.timeScale = 0f;
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
