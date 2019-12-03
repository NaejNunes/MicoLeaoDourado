using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{
    public int sexo;
    public Animator animacao;
    public GameObject painelMenu;
    public bool menuEstado;
    public float velocidadeMover;

    private void Awake()
    {
        sexo = PlayerPrefs.GetInt("Sexo");
    }
    // Start is called before the first frame update
    void Start()
    {
        animacao = GetComponent<Animator>();
        menuEstado = false;
    }

    // Update is called once per frame
    void Update()
    {
        SexoPersonagem();
        MovimentacaoPlayer();
        PainelMenu();
    }

    public void SexoPersonagem()
    {
        if (sexo == 1)
        {
            animacao.SetBool("Sexo", true);
        }

        else if (sexo == 2)
        {
            animacao.SetBool("Sexo", false);
        }
    }

    public void PainelMenu()
    {      
        if (Input.GetKeyDown(KeyCode.I) && menuEstado == false)
        {
            menuEstado = !menuEstado;
            painelMenu.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.I) && menuEstado == true)
        {
            menuEstado = !menuEstado;
            painelMenu.SetActive(false);
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
