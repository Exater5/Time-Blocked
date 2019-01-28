using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaCopia : MonoBehaviour
{
    public GameObject bolaOriginal;
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = bolaOriginal.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D conElQueChocas)
    {
        if (conElQueChocas.CompareTag("Finish"))
        {
            Debug.Log("Una menos, ahora hay:"+ScriptBola.numeroBolas +  " bolas");
            Destroy(gameObject);
        }
    }
}