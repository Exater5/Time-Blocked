using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ScriptBola : MonoBehaviour
{

    //Variables del juego
    public static Transform trBola;
    SpriteRenderer srActualBola;
    public Sprite bolaPrehistoria;
    public Sprite bolaFuturo;
    bool cambio = false;
    void Start()
    {
        srActualBola = GetComponent<SpriteRenderer>();
        srActualBola.sprite = srActualBola.sprite;
    }

        // Update is called once per frame
    void Update()
    {
        trBola = transform;

        if(MaquinaTiempo.prehistoria == true && cambio == false)
        {
            srActualBola.sprite = bolaPrehistoria;
            cambio = true;
        }
        if (MaquinaTiempo.prehistoria == false && cambio == true)
        {
            srActualBola.sprite = bolaFuturo;
            cambio = false;
        }
    }
    //Para acabar la partida si la bola se sale

    void OnTriggerEnter2D(Collider2D conElQueChocas){

        if (conElQueChocas.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }

}

