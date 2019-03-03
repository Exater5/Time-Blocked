using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonPausaSprites : MonoBehaviour
{
    Image imagen;
    public Sprite iconoPausa;
    public Sprite iconoPlay;
    bool pulsas = false;
    // Start is called before the first frame update
    void Start()
    {
        imagen = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AlPulsar()
    {
        pulsas = !pulsas;

        if(pulsas == true)
        {
            imagen.sprite = iconoPlay;
        }
        else
        {
            imagen.sprite = iconoPausa;
        }
    }
}
