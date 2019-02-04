using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoraColisiones : MonoBehaviour
{
    GameObject bola;
    public GameObject[] bolas;
    public int numeroBolas;
    public int bolasInicio;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        bolas = GameObject.FindGameObjectsWithTag("Bola");
        for (int i = 1; i < numeroBolas; ++i)
        {
           
        }
        numeroBolas = bolas.Length;
    }
}
