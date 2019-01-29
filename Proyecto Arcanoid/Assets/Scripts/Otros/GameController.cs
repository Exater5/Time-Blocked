using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public Animator animMenu;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            animMenu.SetBool("Sales", true);
            Time.timeScale = 0f;
        }
        
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
}
