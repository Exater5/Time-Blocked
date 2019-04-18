using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDetectorBarra : MonoBehaviour
{
    Vector2 posicionRaton;
    public Transform trBarra;
    private float dureza = 50f;
    bool movido = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        posicionRaton.y = trBarra.position.y;
        trBarra.position = Vector2.MoveTowards(trBarra.position, posicionRaton, dureza * Time.deltaTime);

        if(Movimiento.enPartida == false || ReiniciaBola.activo == true)
        {
            transform.position = new Vector3(0.8f, -5.5f, 1);
        }
        else
        {
            transform.position = new Vector3(0.8f, -5.5f, -1);
        }
       
    }
    private void OnMouseOver()
    {
        posicionRaton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseEnter()
    {
        if (Input.touchCount == 2)
        {
            Movimiento.lanza = true;

        }

    }
}
