using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temporizador : MonoBehaviour
{
    float contador;
    public float tiempoReduccion = 20f;
    bool dificulta = false;
    // Start is called before the first frame update
    void Start()
    {
        contador = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        contador = Time.time;
        if(contador > tiempoReduccion && dificulta == false)
        {
            transform.localScale -= new Vector3(0.2f, 0, 0);
            dificulta = true;
            Movimiento.bordeDerecho = Movimiento.bordeDerecho + 0.7f;
            Movimiento.bordeIzquierdo = Movimiento.bordeIzquierdo - 0.7f;

        }
    }

}
