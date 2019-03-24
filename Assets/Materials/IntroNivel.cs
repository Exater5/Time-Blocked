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
        
    }
    private void OnMouseDown()
    {
        PasaEscena();
    }
    void PasaEscena()
    {
        SceneManager.LoadScene(1);
    }
}
