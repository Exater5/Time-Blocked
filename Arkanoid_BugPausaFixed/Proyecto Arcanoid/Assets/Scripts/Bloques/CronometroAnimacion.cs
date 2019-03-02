using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CronometroAnimacion : MonoBehaviour

{
	Animator animacion;
	public float segundosEspera=0f;
    
    private float tick;
    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
        tick = Time.time + segundosEspera;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= tick)
        {
        	animacion.SetTrigger("Cronometro");
        }
    }
}
