using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListaBolas : MonoBehaviour
{
    //Variables Bolas
    public int numeroBolas;
    public List<GameObject> bolas;
    public static int vidas = 5;
    public static SpriteRenderer srActualBola;
    //Variables de texto
    public Text textoVidas;
    public Text textoPuntuacion;
    // Start is called before the first frame update
    void Start()
    {
        textoVidas.text = vidas.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        bolas = new List<GameObject>(GameObject.FindGameObjectsWithTag("Bola"));
        numeroBolas = bolas.Count;
        textoVidas.text = vidas.ToString();
        
        if (vidas <= 0)
        {
            textoVidas.text = "GAME OVER";
            textoPuntuacion.text = "GAME OVER";
            Time.timeScale = 0f;
            Debug.Log("Game Over");
        }
        if (numeroBolas <= 0)
        {
            Movimiento.enPartida = false;
            Movimiento.respawn = true;
            --vidas;
        }
    }
}
