using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public Animator animMenu;
    public Animator animMundos;

    // Start is called before the first frame update
    void Start()
    {
        animMenu = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
           
        
    }


    public void CargaBotonesNiveles()
    {
        animMundos.SetTrigger("PulsarBotonInicio");
    }
    public void CargaNivel()
    {
        SceneManager.LoadScene(1);
    }
    public void CargaMenu()
    {
        SceneManager.LoadScene(0);
    }
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
}
