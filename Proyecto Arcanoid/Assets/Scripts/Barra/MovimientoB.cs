using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoB : MonoBehaviour
{
    public GameObject jugador;
    public Vector2 posicionRaton;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        posicionRaton = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        posicionRaton.y = -4f;
        
        
        jugador.transform.position = posicionRaton;

        

    }

}
