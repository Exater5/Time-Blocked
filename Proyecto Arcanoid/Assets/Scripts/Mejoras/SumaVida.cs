using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumaVida : MonoBehaviour
{
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
            ++ScriptBola.vidas; 
            sr.enabled = false;
            Destroy(gameObject);
        }
    }
}
