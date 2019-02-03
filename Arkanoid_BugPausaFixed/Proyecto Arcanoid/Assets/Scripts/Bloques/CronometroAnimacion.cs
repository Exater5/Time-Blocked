using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CronometroAnimacion : MonoBehaviour

{
	Animator animacion;
	public float tiempo;
	public float segundosEspera=0f;
    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = Time.time;
        if(tiempo>=segundosEspera)
        {
        	animacion.SetTrigger("Cronometro");
        }
    }
}
