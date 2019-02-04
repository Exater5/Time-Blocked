using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquePrehistoria : MonoBehaviour
{
    public int vidas;
    public GameObject particulas;
    public bool destruible = false;
    public Sprite sprite1vida;
    float numeroAleatorio;
    public List<GameObject> powerUps;
    GameObject mejora;
    SpriteRenderer sr;
    [TextArea]
    public string sobreProbabilidad = "La probabilidad es entre 8, es decir, el valor 8 es 100% y 80 es 10%";
    [Range(8f, 100f)]
    public float probabilidad;

    private void Start()
    {
        numeroAleatorio = Mathf.Round(Random.Range(1f, probabilidad));
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (vidas <= 0)
        {
            int numeroFix = (int)numeroAleatorio;
            if (numeroAleatorio <= 8)
            {
                mejora = powerUps[powerUps.Count +1 - numeroFix];
                Instantiate(mejora, transform.position, transform.rotation);
            }
            Instantiate(particulas, transform.position, transform.rotation);

            Destroy(gameObject);

        }

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (MaquinaTiempo.prehistoria == true)
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
            if (vidas == 1)
            {
                CambiaSprite();
            }
        }
    }
    void CambiaSprite()
    {
        sr.sprite = sprite1vida;
    }
}
