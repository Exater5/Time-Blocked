using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroNivel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        Invoke("PasaEscena", 25f);
    }

    // Update is called once per frame
    void Update()
    {
        
=======
        if (PlayerPrefs.GetInt("FirstTime") == 1)
            PasaEscena();
        else
            Invoke("PasaEscena", 24f);
>>>>>>> 92899486bcf72a3e3d894939d9b3dfc2678a5864
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
