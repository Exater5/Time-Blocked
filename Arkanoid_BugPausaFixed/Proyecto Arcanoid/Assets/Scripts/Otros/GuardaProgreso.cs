using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GuardaProgreso : MonoBehaviour
{
    public static int nivelesDesbloqueados;
    public Button mundo2;
    public Button mundo3;
    public Button mundo4;
    public Button mundo5;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("Niveles");
        Debug.Log(PlayerPrefs.GetInt("Niveles").ToString());
    }

    // Update is called once per frame
    void Update()
    {
 
        if (PlayerPrefs.GetInt("Niveles") >= 1)
        {
            mundo2.interactable = true;
        }
        if (PlayerPrefs.GetInt("Niveles") >= 2)
        {
            mundo3.interactable = true;
        }
        if (PlayerPrefs.GetInt("Niveles") >= 3)
        {
            mundo4.interactable = true;
        }
        if (PlayerPrefs.GetInt("Niveles") >= 4)
        {
            mundo5.interactable = true;
        }
        
    }
    public static void SumaNivel()
    {
        nivelesDesbloqueados = PlayerPrefs.GetInt("Niveles");
        ++nivelesDesbloqueados;       
        PlayerPrefs.SetInt("Niveles", nivelesDesbloqueados);
        PlayerPrefs.Save();
    }
}
