using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueFuturo : MonoBehaviour
{
    public int vidas;
    public GameObject particulas;
    public bool destruible = true;
    float numeroAleatorio;
    public List<GameObject> powerUps;
    GameObject mejora;
    private void Start()
    {
        numeroAleatorio = Mathf.Round(Random.Range(0f, 20f));
    }
    void Update()
    {

        if (vidas <= 0)
        {
            int numeroRounded = (int)numeroAleatorio;
            if (numeroAleatorio <= 8)
            {
                mejora = powerUps[powerUps.Count - numeroRounded];
                Instantiate(mejora, transform.position, transform.rotation);
                Debug.Log(Mathf.Round(numeroAleatorio));
            }
            Instantiate(particulas, transform.position, transform.rotation);

            Destroy(gameObject);

        }

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (MaquinaTiempo.prehistoria == false)
        {
            destruible = true;
        }
        else
        {
            destruible = false;
        }
        if (col.gameObject.CompareTag("Bola") && destruible == true)
        {
            --vidas;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (MaquinaTiempo.prehistoria == false)
        {
            destruible = true;
        }
        else
        {
            destruible = false;
        }
        if (col.gameObject.CompareTag("Bola") && destruible == true)
        {
            --vidas;
        }
    }
}