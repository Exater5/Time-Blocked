using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour {

    public GameObject laser;
    public GameObject plataformaDisparo;
    public float duracion = 4f;
    public float fuerzaDisparo = 10f;
    GameObject jugador;
    GameObject plataformaFinal;
    SpriteRenderer sr;
    Transform puntoDisparoIzquierdo;
    Transform puntoDisparoDerecho;
    bool toca = false;
    int contadorColisiones = 0;

	// Use this for initialization

	void Start () {
        sr = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame

	void Update () {

        if (toca == true)
        {
            plataformaFinal.transform.position = jugador.transform.position;
            puntoDisparoDerecho = plataformaFinal.transform.GetChild(0);
            puntoDisparoIzquierdo = plataformaFinal.transform.GetChild(1);
        }
        if(Input.touchCount == 2)
        {
            GameObject nuevoLaser;
            nuevoLaser = Instantiate(laser, puntoDisparoIzquierdo.position, puntoDisparoIzquierdo.rotation);
            nuevoLaser.GetComponent<Rigidbody2D>().AddForce(Vector2.up * fuerzaDisparo);
            nuevoLaser = Instantiate(laser, puntoDisparoDerecho.position, puntoDisparoDerecho.rotation);
            nuevoLaser.GetComponent<Rigidbody2D>().AddForce(Vector2.up * fuerzaDisparo);
        }          
    }

    //OnCollision

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            ++contadorColisiones;
            jugador = col.gameObject;    
            if(contadorColisiones == 1)
            {
                plataformaFinal = Instantiate(plataformaDisparo, jugador.transform.position, jugador.transform.rotation);
            }
                      
            toca = true;
            sr.enabled = false;
            Invoke("AutoDestruccion", duracion);
        }
    }

 
    void AutoDestruccion()
    {
        Destroy(plataformaFinal);
        Destroy(gameObject);
    }
}
