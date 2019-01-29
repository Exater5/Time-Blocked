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

    // Update is called once per frame
    void Update()
    {

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

            Destroy(gameObject);
        }
    }
}
