using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestruccion : MonoBehaviour
{
    public float tiempoVida = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Autodestruye", tiempoVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Autodestruye()
    {
        Destroy(gameObject);
    }
}
