using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour {
    public AudioMixer mixer;
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
            mixer.SetFloat("volMusica", 0f);
        }

        else
        {
            mixer.SetFloat("volMusica", -80f);
        }
    }

    public void BotonFx()
    {
        fxActivada = !fxActivada;

        if(fxActivada == true)
        {
            mixer.SetFloat("volFx", 0f);
        }
        else
        {
            mixer.SetFloat("volFx", -80f);
        }
    } 
}
