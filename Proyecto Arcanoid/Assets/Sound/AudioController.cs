using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour {
    public AudioMixer mixerMusica;
    public AudioMixer mixerFx;
    public Animator animaBoton;

    public bool activada = true;
    public bool fxActivada = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       
        
    }
    public void BotonMusica()
    {
        
        activada = !activada;

        if(activada == true)
        {
            mixerMusica.SetFloat("volMusica", 0f);
        }

        else
        {
            mixerMusica.SetFloat("volMusica", -80f);
        }
    }

    public void BotonFx()
    {
        fxActivada = !fxActivada;

        if(fxActivada == true)
        {
            mixerFx.SetFloat("volFx", 0f);
        }
        else
        {
            mixerFx.SetFloat("volFx", -80f);
        }
    } 
}
