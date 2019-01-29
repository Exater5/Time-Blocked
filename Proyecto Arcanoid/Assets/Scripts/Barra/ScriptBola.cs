using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ScriptBola : MonoBehaviour
{

    //Variables del juego
    public static Transform trBola;
    public static SpriteRenderer srActualBola;
    void Start()
    {
        srActualBola = GetComponent<SpriteRenderer>();
    }

        // Update is called once per frame
    void Update()
    {
        trBola = transform;
        
    }
    //Para acabar la partida si la bola se sale

    void OnTriggerEnter2D(Collider2D conElQueChocas){

        if (conElQueChocas.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }




}

