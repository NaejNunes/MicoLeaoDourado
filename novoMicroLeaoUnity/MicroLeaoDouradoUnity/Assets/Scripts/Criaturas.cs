using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Criaturas : MonoBehaviour
{
    public int[] vida, energia, ataque, velocidade;
    public int contMove;
    public float velMove, tempoAndar;
    public Animator animacoes;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        animacoes = GetComponent<Animator>();

        tempoAndar -= Time.deltaTime;

        if (tempoAndar <= 0)
        {
            Movimentar();
        }
    }

    public void Movimentar()
    {
        contMove = Random.Range(0,5);

        switch (contMove)
        {
            case 1:
                transform.position += new Vector3(0, velMove, 0);
                this.animacoes.SetFloat("Andando", velMove);
                break;

            case 2:
                transform.position += new Vector3(velMove, 0, 0);
                this.animacoes.SetFloat("Andando", velMove);
                break;

            case 3:
                transform.position += new Vector3(0, -velMove, 0);
                this.animacoes.SetFloat("Andando", velMove);
                break;

            case 4:
                transform.position += new Vector3(-velMove, 0, 0);
                this.animacoes.SetFloat("Andando", velMove);
                break;

            case 5:
                this.animacoes.SetBool("Parado", true);
                break;
        }
    }
}
