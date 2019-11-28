using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadeMover;
    public int vida, energia, ataque, defesa, velocidade, acerto;
    public bool morto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentacaoPlayer();

        if (vida <= 0)
        {
            morto = true;
        }
    }

    public void MovimentacaoPlayer()
    {
        //atribui os valores para movimentar pelos botoes
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if (y == 1)
        {
            //Recebe a posicao para se movimentar.
            transform.position += new Vector3(0, velocidadeMover, 0);
        }
        else if (x == 1)
        {
            transform.position += new Vector3(velocidadeMover, 0, 0);
        }
        else if (y == -1)
        {
            transform.position += new Vector3(0, -velocidadeMover, 0);
        }

        else if (x == -1)
        {
            transform.position += new Vector3(-velocidadeMover, 0, 0);
        }
    }
  
}
