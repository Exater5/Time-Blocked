using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    public float velocidadMovimiento = 0.1f;
    public static float bordeIzquierdo = -5f;
    public static float bordeDerecho = 5f;


	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-velocidadMovimiento, 0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(velocidadMovimiento, 0, 0);
        }
        if (transform.position.x < bordeIzquierdo)
        {
            transform.position = new Vector2(bordeIzquierdo, transform.position.y);
        }
        if (transform.position.x > bordeDerecho)
        {
            transform.position = new Vector2(bordeDerecho, transform.position.y);
        }

    }


}
