using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaRapida : MonoBehaviour
{
    public Rigidbody2D rbBola;
    public float duracion = 3f;
    SpriteRenderer sr;
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
    {
        if (col.gameObject.CompareTag("Player"))
        {
            rbBola.velocity = rbBola.velocity * 2;
            sr.enabled = false;

            Invoke("VelocidadNormal", duracion);
        }
    }
    void VelocidadNormal()
    {
        rbBola.velocity = rbBola.velocity / 2;
        Destroy(gameObject);
    }
}