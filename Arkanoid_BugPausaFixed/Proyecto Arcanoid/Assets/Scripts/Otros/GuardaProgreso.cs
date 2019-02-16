using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GuardaProgreso : MonoBehaviour
{
    public int nivelesDesbloqueados = 1;
    bool primeraVez = true;
    public Button mundo1;
    public Button mundo2;
    public Button mundo3;
    public Button mundo4;
    public Button mundo5;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Niveles", nivelesDesbloqueados);
    }

    // Update is called once per frame
    void Update()
    {
  

        if (nivelesDesbloqueados >= 1)
        {
            mundo1.interactable = true;
        }
        if (nivelesDesbloqueados >= 2)
        {
            mundo2.interactable = true;
        }
        if (nivelesDesbloqueados >= 3)
        {
            mundo3.interactable = true;
        }
        if (nivelesDesbloqueados >= 4)
        {
            mundo4.interactable = true;
        }
        if (nivelesDesbloqueados >= 5)
        {
            mundo5.interactable = true;
        }
        
    }
    public void SumaNivel()
    {
        ++nivelesDesbloqueados;       
        PlayerPrefs.SetInt("Niveles", nivelesDesbloqueados);
        nivelesDesbloqueados = PlayerPrefs.GetInt("Niveles", 0);
        Debug.Log(nivelesDesbloqueados);

        Debug.Log("Se ha cumplido la funcion, ahora hay " + nivelesDesbloqueados + "niveles disponibles");

    }
}
