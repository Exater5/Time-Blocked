using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TresBolas : MonoBehaviour
{
    public GameObject bola;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            sr.enabled = false;
            GameObject bola1;
            GameObject bola2;
            bola1 = Instantiate(bola, ScriptBola.trBola.position + new Vector3(0.5f, 0, 0), ScriptBola.trBola.rotation);
            bola1.GetComponent<Rigidbody2D>().velocity = bola.GetComponent<Rigidbody2D>().velocity + new Vector2(5f, 5f);

            bola2 = Instantiate(bola, ScriptBola.trBola.position - new Vector3(0.5f, 0, 0), ScriptBola.trBola.rotation);
            bola2.GetComponent<Rigidbody2D>().velocity = bola.GetComponent<Rigidbody2D>().velocity - new Vector2(10f, 10f);

            IgnoraColisiones(bola1);
            IgnoraColisiones(bola2);

            Destroy(gameObject);
        }
    }

    private void IgnoraColisiones(GameObject bola)
    {
        GameObject[] bolas = GameObject.FindGameObjectsWithTag("Bola");

        for (int i = 0; i < bolas.Length; i++) {
            Physics2D.IgnoreCollision(bola.GetComponent<Collider2D>(), bolas[i].GetComponent<Collider2D>());
        }

    }
}
