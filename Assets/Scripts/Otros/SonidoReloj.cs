using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoReloj : MonoBehaviour
{
    AudioSource glitch;
    // Start is called before the first frame update
    void Start()
    {
        glitch = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pulsas()
    {
        glitch.Play();
    }
}
