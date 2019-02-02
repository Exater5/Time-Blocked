using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour {
    public AudioMixer mixer;
    public Sprite spriteMusicaActivada;
    public Sprite spriteMusicaDesactivada;
    public Image imagenMusica;
    public Sprite spriteFxActivada;
    public Sprite spriteFxDesactivada;
    public Image imagenFx;
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
            imagenMusica.sprite = spriteMusicaActivada;
        }

        else
        {
            mixer.SetFloat("volMusica", -80f);
            imagenMusica.sprite = spriteMusicaDesactivada;
        }
    }

    public void BotonFx()
    {
        fxActivada = !fxActivada;

        if(fxActivada == true)
        {
            mixer.SetFloat("volFx", 0f);
            imagenFx.sprite = spriteFxActivada;
        }
        else
        {
            mixer.SetFloat("volFx", -80f);
            imagenFx.sprite = spriteFxDesactivada;
        }
    } 
}
