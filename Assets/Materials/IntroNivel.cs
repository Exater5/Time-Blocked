using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroNivel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Invoke("PasaEscena", 25f);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (PlayerPrefs.GetInt("FirstTime") == 1)
            PasaEscena();
        else
            Invoke("PasaEscena", 24f);
    }
    
    private void OnMouseDown()
    {
        //PasaEscena();
    }

    void PasaEscena() {
        PlayerPrefs.SetInt("FirstTime", 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene(1);
    }
}
