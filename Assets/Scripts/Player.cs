using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimentar();
    }

    void Movimentar()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(-Vector2.right * velocidade * Time.deltaTime);
        }
    }
}
