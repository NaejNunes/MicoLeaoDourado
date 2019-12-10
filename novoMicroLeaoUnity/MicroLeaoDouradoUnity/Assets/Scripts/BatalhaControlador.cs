using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatalhaControlador : MonoBehaviour
{
    public int[] posicaoUm, posicaoDois, posicaoTres;
    public static float posX, posY;
    public GameObject[] criaturas, botoesAcoes, painelInimigos, painelPlayer, targetInimigo;
    public GameObject menino, menina;
    public int sexo, qtdAcoes, qtdAtaque, qtdPosicaoAtual, vezPlayer;
    public Text[] txtJogador;
    public bool acoes, ataque, habilidade, correr, PrimeiraAcao, SegundaAcao, TerceiraAcao;

    private void Awake()
    {
        CarregarFolcoresAtivos();
        sexo = PlayerPrefs.GetInt("Sexo");
    }
    // Start is called before the first frame update
    void Start()
    {
        CarregarFolclores();
        PrimeiraAcao = true;
        SegundaAcao = false;
        TerceiraAcao = false;
    }

    // Update is called once per frame
    void Update()
    {
        posX = transform.position.x;
        posY = transform.position.y;

        VezDoPlayer();

        if (PrimeiraAcao == true)
        {
            AcoesControle();
        }
        if (SegundaAcao == true && ataque == true)
        {
            PrimeiraAcao = false;
            AcaoAtacar();
        }

        if (SegundaAcao == true && habilidade == true)
        {

        }
    }

    public void CarregarFolclores()
    {
        if (sexo == 1)
        {
            Instantiate(this.menina, new Vector2(BatalhaControlador.posX - 6f, BatalhaControlador.posY), Quaternion.identity);
        }
        else if (sexo == 2)
        {
            Instantiate(this.menino, new Vector2(BatalhaControlador.posX - 6f, BatalhaControlador.posY), Quaternion.identity);
        }

        if (posicaoUm[0] == 1)
        {
            Instantiate(this.criaturas[0], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY + 3f), Quaternion.identity);
            txtJogador[0].text = "Saci-Perere";
        }
        if (posicaoUm[1] == 2)
        {
            Instantiate(this.criaturas[1], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY + 3f), Quaternion.identity);
            txtJogador[1].text = "Mula Sem Cabeça";
        }
        if (posicaoUm[2] == 3)
        {
            Instantiate(this.criaturas[2], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY + 3f), Quaternion.identity);
            txtJogador[2].text = "Lobisomem";
        }
        if (posicaoUm[3] == 4)
        {
            Instantiate(this.criaturas[3], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY + 3f), Quaternion.identity);
            txtJogador[3].text = "Caipora";
        }
        if (posicaoUm[4] == 5)
        {
            Instantiate(this.criaturas[4], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY + 3f), Quaternion.identity);
            txtJogador[4].text = "Iara";
        }
        if (posicaoUm[5] == 6)
        {
            Instantiate(this.criaturas[5], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY + 3f), Quaternion.identity);
            txtJogador[5].text = "Curupira";
        }
        if (posicaoUm[6] == 7)
        {
            Instantiate(this.criaturas[6], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY + 3f), Quaternion.identity);
            txtJogador[6].text = "Cuca";
        }
        if (posicaoUm[7] == 8)
        {
            Instantiate(this.criaturas[7], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY + 3f), Quaternion.identity);
            txtJogador[7].text = "Boto Cor de Rosa";
        }
        if (posicaoUm[8] == 9)
        {
            Instantiate(this.criaturas[8], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY + 3f), Quaternion.identity);
            txtJogador[8].text = "Boitatá";
        }
        if (posicaoDois[0] == 10)
        {
            Instantiate(this.criaturas[0], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY + 3f), Quaternion.identity);
            txtJogador[9].text = "Saci-Perere";
        }
        if (posicaoDois[1] == 11)
        {
            Instantiate(this.criaturas[1], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY), Quaternion.identity);
            txtJogador[10].text = "Mula Sem Cabeça";
        }
        if (posicaoDois[2] == 12)
        {
            Instantiate(this.criaturas[2], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY), Quaternion.identity);
            txtJogador[11].text = "Lobisomem";
        }
        if (posicaoDois[3] == 13)
        {
            Instantiate(this.criaturas[3], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY), Quaternion.identity);
            txtJogador[12].text = "Caipora";
        }
        if (posicaoDois[4] == 14)
        {
            Instantiate(this.criaturas[4], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY ), Quaternion.identity);
            txtJogador[13].text = "Iara";
        }
        if (posicaoDois[5] == 15)
        {
            Instantiate(this.criaturas[5], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY ), Quaternion.identity);
            txtJogador[14].text = "Curupira";
        }
        if (posicaoDois[6] == 16)
        {
            Instantiate(this.criaturas[6], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY ), Quaternion.identity);
            txtJogador[15].text = "Cuca";
        }
        if (posicaoDois[7] == 17)
        {
            Instantiate(this.criaturas[7], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY), Quaternion.identity);
            txtJogador[16].text = "Boto Cor de Rosa";
        }
        if (posicaoDois[8] == 18)
        {
            Instantiate(this.criaturas[8], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY ), Quaternion.identity);
            txtJogador[17].text = "Boitatá";
        }
        if (posicaoTres[0] == 19)
        {
            Instantiate(this.criaturas[0], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY - 3f), Quaternion.identity);
            txtJogador[18].text = "Saci-Perere";
        }
        if (posicaoTres[1] == 20)
        {
            Instantiate(this.criaturas[1], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY - 3f), Quaternion.identity);
            txtJogador[19].text = "Mula Sem Cabeça";
        }
        if (posicaoTres[2] == 21)
        {
            Instantiate(this.criaturas[2], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY - 3f), Quaternion.identity);
            txtJogador[20].text = "Lobisomem";
        }
        if (posicaoTres[3] == 22)
        {
            Instantiate(this.criaturas[3], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY - 3f), Quaternion.identity);
            txtJogador[21].text = "Caipora";
        }
        if (posicaoTres[4] == 23)
        {
            Instantiate(this.criaturas[4], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY - 3f), Quaternion.identity);
            txtJogador[22].text = "Iara";
        }
        if (posicaoTres[5] == 24)
        {
            Instantiate(this.criaturas[5], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY - 3f), Quaternion.identity);
            txtJogador[23].text = "Curupira";
        }
        if (posicaoTres[6] == 25)
        {
            Instantiate(this.criaturas[6], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY - 3f), Quaternion.identity);
            txtJogador[24].text = "Cuca";
        }
        if (posicaoTres[7] == 26)
        {
            Instantiate(this.criaturas[7], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY - 3f), Quaternion.identity);
            txtJogador[25].text = "Boto Cor de Rosa";
        }
        if (posicaoTres[8] == 27)
        {
            Instantiate(this.criaturas[8], new Vector2(BatalhaControlador.posX - 4f, BatalhaControlador.posY - 3f), Quaternion.identity);
            txtJogador[26].text = "Boitatá";
        }
    }

    public void CarregarFolcoresAtivos()
    {
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

    public void AcoesControle()
    {
        if (qtdAcoes < 0)
        {
            qtdAcoes = 0;
        }
        if (qtdAcoes > 2)
        {
            qtdAcoes = 2;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            qtdAcoes--;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            qtdAcoes++;
        }

        if (ataque == false || habilidade == false || correr == false)
        {       
            if (qtdAcoes == 0)
            {
                 //Atacar         
                botoesAcoes[0].GetComponent<Image>().color = Color.green;
                botoesAcoes[1].GetComponent<Image>().color = Color.blue;
                botoesAcoes[2].GetComponent<Image>().color = Color.blue;

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    ataque = true;
                    qtdPosicaoAtual++;
                    SegundaAcao = true;
                }                        
            }

            else if (qtdAcoes == 1)
            {
                //Habilidade
                botoesAcoes[0].GetComponent<Image>().color = Color.blue;
                botoesAcoes[1].GetComponent<Image>().color = Color.green;
                botoesAcoes[2].GetComponent<Image>().color = Color.blue;

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    habilidade = true;
                    qtdPosicaoAtual++;
                    SegundaAcao = true;
                }
            }
            else if (qtdAcoes == 2)
            {
                //Fugir
                botoesAcoes[0].GetComponent<Image>().color = Color.blue;
                botoesAcoes[1].GetComponent<Image>().color = Color.blue;
                botoesAcoes[2].GetComponent<Image>().color = Color.green;

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    correr = true;
                    qtdPosicaoAtual++;
                    SegundaAcao = true;
                }
            }
        }   
    }

    public void AcaoAtacar()
    {
        if (ataque == true && qtdAtaque == 0)
        {
            targetInimigo[0].SetActive(true);
            targetInimigo[1].SetActive(false);

            painelInimigos[0].GetComponent<Image>().color = Color.green;
            painelInimigos[1].GetComponent<Image>().color = Color.blue;
        }
        else if (ataque == true && qtdAtaque == 1)
        {
            targetInimigo[0].SetActive(false);
            targetInimigo[1].SetActive(true);

            painelInimigos[0].GetComponent<Image>().color = Color.blue;
            painelInimigos[1].GetComponent<Image>().color = Color.green;
        }

        if (qtdAtaque < 0)
        {
            qtdAtaque = 0;
        }
        else if (qtdAtaque > 1)
        {
            qtdAtaque = 1;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            qtdAtaque--;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            qtdAtaque++;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (vezPlayer == 0 && posicaoDois[0] == 1)
            {
                Debug.Log("Atacou");
                //Causar Dano

            }
        }

    }

    public void AcaoHabilidade()
    {

    }

    public void AcaoCorrer()
    {

    }

    public void VezDoPlayer()
    {
        if (vezPlayer == 0)
        {
            painelPlayer[0].GetComponent<Image>().color = Color.green;
            painelPlayer[1].GetComponent<Image>().color = Color.blue;
            painelPlayer[2].GetComponent<Image>().color = Color.blue;
            painelPlayer[3].GetComponent<Image>().color = Color.blue;
        }

        if (vezPlayer == 1)
        {
            painelPlayer[0].GetComponent<Image>().color = Color.blue;
            painelPlayer[1].GetComponent<Image>().color = Color.green;
            painelPlayer[2].GetComponent<Image>().color = Color.blue;
            painelPlayer[3].GetComponent<Image>().color = Color.blue;
        }

        if (vezPlayer == 2)
        {
            painelPlayer[0].GetComponent<Image>().color = Color.blue;
            painelPlayer[1].GetComponent<Image>().color = Color.blue;
            painelPlayer[2].GetComponent<Image>().color = Color.green;
            painelPlayer[3].GetComponent<Image>().color = Color.blue;
        }

        if (vezPlayer == 3)
        {
            painelPlayer[0].GetComponent<Image>().color = Color.blue;
            painelPlayer[1].GetComponent<Image>().color = Color.blue;
            painelPlayer[2].GetComponent<Image>().color = Color.blue;
            painelPlayer[3].GetComponent<Image>().color = Color.green;
        }
    }
}
