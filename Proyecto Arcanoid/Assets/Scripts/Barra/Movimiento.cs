using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
    //Variables Movimiento
    public static float bordeIzquierdo = -4.5f;
    public static float bordeDerecho = 4.5f;
    Vector2 posicionRaton;
    bool lanza = false;
    //Variables Bola
    public static float velocidadSalida = 500f;
    public GameObject bola;
    public static Rigidbody2D rbBola;
    public static bool enPartida;
    GameObject nuevaBola;
    public static bool respawn = true;
    int cuentaToques = 0;
    // Use this for initialization
    void Start ()
    {      
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!enPartida)
        {
            if (respawn == true)
            {
                nuevaBola = Instantiate(bola, transform.position + new Vector3(0, 1, 0), transform.rotation);
                rbBola = nuevaBola.GetComponent<Rigidbody2D>();
                respawn = false;
            }
            nuevaBola.transform.position = transform.position + new Vector3(0, 1, 0);
            Time.timeScale = 0f;
        }
        if (lanza == true &&!enPartida)
        {
            enPartida = true;
            Time.timeScale = 1f;
            rbBola.AddForce(Vector2.up * velocidadSalida);
            lanza = false;

        }
        //Movimiento
        
        posicionRaton.y = transform.position.y;
        transform.position = posicionRaton;

        if (transform.position.x < bordeIzquierdo)
        {
            transform.position = new Vector2(bordeIzquierdo, transform.position.y);
        }
        if (transform.position.x > bordeDerecho)
        {
            transform.position = new Vector2(bordeDerecho, transform.position.y);
        }

    }
    private void OnMouseDown()
    {
        lanza = true;
        if(ReiniciaBola.cogeMejora == true)
        {
            ReiniciaBola.lanza = true;
        }
       
    }
    private void OnMouseEnter()
    {
        if(Input.touchCount == 2)
        {
            lanza = true;

        }
       
    }
    private void OnMouseOver()
    {
        posicionRaton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
