using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueFuturo : MonoBehaviour
{
    AudioSource sonidoRotura;
    public int vidas;
    public GameObject particulas;
    public bool destruible = true;
    public Sprite sprite1vida;
    float numeroAleatorio;
    public List<GameObject> powerUps;
    GameObject mejora;
    SpriteRenderer sr;
    [TextArea]
    public string sobreProbabilidad = "La probabilidad es entre 8, es decir, el valor 8 es 100% y 80 es 10%";
    [Range(8f, 100f)]
    public float numeroMaximo;
    private void Start()
    {
        numeroAleatorio = Mathf.Round(Random.Range(1f, numeroMaximo));
        sr = GetComponent<SpriteRenderer>();
        sonidoRotura = GetComponent<AudioSource>();
    }
    void Update()
    {

        if (vidas <= 0)
        {
            int numeroRounded = (int)numeroAleatorio;
            if (numeroRounded <= 8)
            {
                Debug.Log(numeroRounded);
                mejora = powerUps[numeroRounded];
                Instantiate(mejora, transform.position, transform.rotation);
                Destroy(gameObject);
                
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
            sonidoRotura.Play();
            if (vidas == 1)
            {
                CambiaSprite();
            }
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
            sonidoRotura.Play();
            if (vidas == 1)
            {
                CambiaSprite();
            }
        }
    }

    public void CambiaSprite()
    {
        sr.sprite = sprite1vida;
    }
}