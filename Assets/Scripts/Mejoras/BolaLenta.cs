using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaLenta : MonoBehaviour
{
    Rigidbody2D rbBola;
    public float duracion = 3f;
    SpriteRenderer sr;
    GameObject[] bolas;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {/*
        if (col.gameObject.CompareTag("Player"))
        {
           // rbBola.velocity = rbBola.velocity / 2;
           // Debug.Log(rbBola.velocity + "EEEEEEEEEE");
            sr.enabled = false;

            bolas = GameObject.FindGameObjectsWithTag("Bola");
            Debug.Log(bolas[0].transform.name);

            for (int i = 0; i < bolas.Length; ++i)
            {
                rbBola = bolas[i].GetComponent<Rigidbody2D>();
                rbBola.velocity = rbBola.velocity / 2;
            }

            Invoke("VelocidadNormal", duracion);
        }
    }
    void VelocidadNormal()
    {
        for (int i = 0; i < bolas.Length; ++i)
        {
            rbBola = bolas[i].GetComponent<Rigidbody2D>();
            rbBola.AddForce(new Vector2(rbBola.velocity.x,rbBola.velocity.y)*150);
        }
        //rbBola.velocity = rbBola.velocity * 2;
          */
        Destroy(gameObject);
       
    }
   
}
