using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaBolas : MonoBehaviour
{
    public int numeroBolas;
    public List<GameObject> bolas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bolas = new List<GameObject>(GameObject.FindGameObjectsWithTag("Bola"));
        numeroBolas = bolas.Count;
    }
    void OnTriggerEnter2D(Collider2D conElQueChocas)
    {
        if (conElQueChocas.CompareTag("Bola"))
            bolas.Remove(conElQueChocas.gameObject);
        if (numeroBolas <= 0)
        {
            ScriptBola.enPartida = false; 


        }



    }
}
