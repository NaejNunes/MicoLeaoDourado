using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{
    public int sexo, idPainelPersonagem;
    public int[] posicaoUm, posicaoDois, posicaoTres;
    public Animator animacao;
    public GameObject painelMenu, painelUm, painelDois, painelTres;
    public bool menuEstado, criaturaUm, criaturaDois, criaturaTres;
    public float velocidadeMover;

    private void Awake()
    {
        sexo = PlayerPrefs.GetInt("Sexo");

        posicaoUm[0] = PlayerPrefs.GetInt("Folclore0");
        posicaoUm[1] = PlayerPrefs.GetInt("Folclore1");
        posicaoUm[2] = PlayerPrefs.GetInt("Folclore2");
        posicaoUm[3] = PlayerPrefs.GetInt("Folclore3");
        posicaoUm[4] = PlayerPrefs.GetInt("Folclore4");
        posicaoUm[5] = PlayerPrefs.GetInt("Folclore5");
        posicaoUm[6] = PlayerPrefs.GetInt("Folclore6");
        posicaoUm[7] = PlayerPrefs.GetInt("Folclore7");
        posicaoUm[8] = PlayerPrefs.GetInt("Folclore8");

        posicaoDois[0] = PlayerPrefs.GetInt("Folclore9");
        posicaoDois[1] = PlayerPrefs.GetInt("Folclore10");
        posicaoDois[2] = PlayerPrefs.GetInt("Folclore11");
        posicaoDois[3] = PlayerPrefs.GetInt("Folclore12");
        posicaoDois[4] = PlayerPrefs.GetInt("Folclore13");
        posicaoDois[5] = PlayerPrefs.GetInt("Folclore14");
        posicaoDois[6] = PlayerPrefs.GetInt("Folclore15");
        posicaoDois[7] = PlayerPrefs.GetInt("Folclore16");
        posicaoDois[8] = PlayerPrefs.GetInt("Folclore17");

        posicaoTres[0] = PlayerPrefs.GetInt("Folclore18");
        posicaoTres[1] = PlayerPrefs.GetInt("Folclore19");
        posicaoTres[2] = PlayerPrefs.GetInt("Folclore20");
        posicaoTres[3] = PlayerPrefs.GetInt("Folclore21");
        posicaoTres[4] = PlayerPrefs.GetInt("Folclore22");
        posicaoTres[5] = PlayerPrefs.GetInt("Folclore23");
        posicaoTres[6] = PlayerPrefs.GetInt("Folclore24");
        posicaoTres[7] = PlayerPrefs.GetInt("Folclore25");
        posicaoTres[8] = PlayerPrefs.GetInt("Folclore26");
    }
    // Start is called before the first frame update
    void Start()
    {
        animacao = GetComponent<Animator>();
        menuEstado = false;

        idPainelPersonagem = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SexoPersonagem();
        MovimentacaoPlayer();
        PainelMenu();

        TrocarPersonagem();
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

    public void TrocarPersonagem()
    {
        if (idPainelPersonagem == 0)
        {
            painelUm.GetComponent<Image>().color = Color.green;
            painelDois.GetComponent<Image>().color = Color.blue;
            painelTres.GetComponent<Image>().color = Color.blue;
            criaturaUm = true;
            criaturaDois = false;
            criaturaTres = false;     
        }

        if (idPainelPersonagem == 1)
        {
            painelUm.GetComponent<Image>().color = Color.blue;
            painelDois.GetComponent<Image>().color = Color.green;
            painelTres.GetComponent<Image>().color = Color.blue;
            criaturaUm = false;
            criaturaDois = true;
            criaturaTres = false;
        }

        if (idPainelPersonagem == 2)
        {
            painelUm.GetComponent<Image>().color = Color.blue;
            painelDois.GetComponent<Image>().color = Color.blue;
            painelTres.GetComponent<Image>().color = Color.green;
            criaturaUm = false;
            criaturaDois = false;
            criaturaTres = true;
        }

        if (Input.GetKeyDown(KeyCode.F1))
        {
            idPainelPersonagem = 0;
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            idPainelPersonagem = 1;
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            idPainelPersonagem = 2;
        }
    }

    public void Habilidades()
    {
        if (posicaoUm[0] == 1 && criaturaUm == true)
        {
            //Habilide Saci
        }

        if (posicaoUm[1] == 2 && criaturaUm == true)
        {
            //Habilide Mula
        }

        if (posicaoUm[2] == 3 && criaturaUm == true)
        {
            //Habilide Lobisomem
        }

        if (posicaoUm[3] == 4 && criaturaUm == true)
        {
            //Habilide Caipora
        }

        if (posicaoUm[4] == 5 && criaturaUm == true)
        {
            //Habilide Iara
        }

        if (posicaoUm[5] == 6 && criaturaUm == true)
        {
            //Habilide Curupira
        }

        if (posicaoUm[6] == 7 && criaturaUm == true)
        {
            //Habilide Cuca
        }

        if (posicaoUm[7] == 8 && criaturaUm == true)
        {
            //Habilide BotoCorDeRosa
        }

        if (posicaoUm[8] == 9 && criaturaUm == true)
        {
            //Habilide Boitata
        }

        if (posicaoDois[0] == 10 && criaturaDois == true)
        {
            //Habilide Saci
        }

        if (posicaoDois[1] == 11 && criaturaDois == true)
        {
            //Habilide MulaSemCabeca
        }

        if (posicaoDois[2] == 12 && criaturaDois == true)
        {
            //Habilide Lobisomem
        }

        if (posicaoDois[3] == 13 && criaturaDois == true)
        {
            //Habilide Caipora
        }

        if (posicaoDois[4] == 14 && criaturaDois == true)
        {
            //Habilide Iara
        }

        if (posicaoDois[5] == 15 && criaturaDois == true)
        {
            //Habilide Curupira
        }

        if (posicaoDois[6] == 16 && criaturaDois == true)
        {
            //Habilide Cuca
        }

        if (posicaoDois[7] == 17 && criaturaDois == true)
        {
            //Habilide BotoCorDeRosa
        }

        if (posicaoDois[8] == 18 && criaturaDois == true)
        {
            //Habilide Boitata
        }

        if (posicaoTres[0] == 19 && criaturaTres == true)
        {
            //Habilide SaciPerere
        }

        if (posicaoTres[1] == 20 && criaturaTres == true)
        {
            //Habilide MulaSemCabeca
        }

        if (posicaoTres[2] == 21 && criaturaTres == true)
        {
            //Habilide Lobisom
        }

        if (posicaoTres[3] == 22 && criaturaTres == true)
        {
            //Habilide Caipora
        }

        if (posicaoTres[4] == 23 && criaturaTres == true)
        {
            //Habilide Iara
        }

        if (posicaoTres[5] == 24 && criaturaTres == true)
        {
            //Habilide Curupira
        }

        if (posicaoTres[6] == 25 && criaturaTres == true)
        {
            //Habilide Cuca
        }

        if (posicaoTres[7] == 26 && criaturaTres == true)
        {
            //Habilide BotoCorDeRosa
        }

        if (posicaoTres[8] == 27 && criaturaTres == true)
        {
            //Habilide Boitata
        }
    }
}
