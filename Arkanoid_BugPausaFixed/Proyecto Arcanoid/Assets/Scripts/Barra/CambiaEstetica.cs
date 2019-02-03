using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaEstetica : MonoBehaviour
{
    Sprite srActual;
    public Sprite spritePrehistoria;
    public Sprite spriteFuturo;
    // Start is called before the first frame update
    void Start()
    {
        Sprite srActual = GetComponent<Sprite>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnMouseDown()
    {
        srActual = spritePrehistoria;
    }
}
