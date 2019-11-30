using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FolcloreControlador : MonoBehaviour
{
    public int statusPainel, idCriaturas;
    public Text[] txtfolcloreSelecionado;
    public bool[] posicaoOcupada, criaturaAtivada;
    public bool posicaoCompleta;
    public GameObject[] painelCriaturas, painelSobreCriaturas;

    public GameObject botaoResetar;

    // Start is called before the first frame update
    void Start()
    {
        statusPainel = 0;

        idCriaturas = 10;

        posicaoOcupada[0] = false;
        posicaoOcupada[1] = false;
        posicaoOcupada[2] = false;

        painelSobreCriaturas[0].SetActive(false);
        painelSobreCriaturas[1].SetActive(false);
        painelSobreCriaturas[2].SetActive(false);
        painelSobreCriaturas[3].SetActive(false);
        painelSobreCriaturas[4].SetActive(false);
        painelSobreCriaturas[5].SetActive(false);
        painelSobreCriaturas[6].SetActive(false);
        painelSobreCriaturas[7].SetActive(false);
        painelSobreCriaturas[8].SetActive(false);

        botaoResetar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GerenciadorPainel();
        IdentificadorCriatura();
    }

    public void GerenciadorPainel()
    {
        //ATIVA OS PAINEIS DE ESCOLHA
        if (statusPainel == 0)
        {
            posicaoOcupada[0] = false;
            posicaoOcupada[1] = false;
            posicaoOcupada[2] = false;

            posicaoCompleta = false;

            botaoResetar.SetActive(false);
        }

        else if (statusPainel == 1)
        {
            posicaoOcupada[0] = true;
            posicaoOcupada[1] = false;
            posicaoOcupada[2] = false;

            posicaoCompleta = false;

            botaoResetar.SetActive(false);
        }

        else if (statusPainel == 2)
        {
            posicaoOcupada[0] = true;
            posicaoOcupada[1] = true;
            posicaoOcupada[2] = false;

            posicaoCompleta = false;

            botaoResetar.SetActive(false);
        }

        else if (statusPainel == 3)
        {
            posicaoOcupada[0] = true;
            posicaoOcupada[1] = true;
            posicaoOcupada[2] = true;

            posicaoCompleta = true;

            botaoResetar.SetActive(true);
        }

        //FAZ COM QUE O STATUS DO PAINEL NAO ULTRAPASSE OS LIMITES
        if (statusPainel > 3)
        {
            statusPainel = 3;
        }
        else if (statusPainel < 0)
        {
            statusPainel = 0;
        }
    }

    public void IdentificadorCriatura()
    {
        if (posicaoOcupada[0] == false && posicaoOcupada[1] == false && posicaoOcupada[2] == false)
        {
             if (idCriaturas == 10)
             {
                txtfolcloreSelecionado[0].text = "Vazio";
             }
        }
        else if (posicaoOcupada[0] == true && posicaoOcupada[1] == false && posicaoOcupada[2] == false)
        {
            if (idCriaturas == 0)
            {
                txtfolcloreSelecionado[0].text = "Saci";
            }

            else if (idCriaturas == 1)
            {
                txtfolcloreSelecionado[0].text = "Curupira";
            }

            else if (idCriaturas == 2)
            {
                txtfolcloreSelecionado[0].text = "Caipora";
            }

            else if (idCriaturas == 3)
            {
                txtfolcloreSelecionado[0].text = "Iara";
            }

            else if (idCriaturas == 4)
            {
                txtfolcloreSelecionado[0].text = "Boto";
            }

            else if (idCriaturas == 5)
            {
                txtfolcloreSelecionado[0].text = "Lobisomem";
            }

            else if (idCriaturas == 6)
            {
                txtfolcloreSelecionado[0].text = "Boitata";
            }

            else if (idCriaturas == 7)
            {
                txtfolcloreSelecionado[0].text = "Mula";
            }

            else if (idCriaturas == 8)
            {
                txtfolcloreSelecionado[0].text = "Cuca";
            }
            else if (idCriaturas == 10)
            {
                txtfolcloreSelecionado[1].text = "Vazio";
            }

        }

        else if (posicaoOcupada[0] == true && posicaoOcupada[1] == true && posicaoOcupada[2] == false)
        {
            if (idCriaturas == 0)
            {
                txtfolcloreSelecionado[1].text = "Saci";
            }

            else if (idCriaturas == 1)
            {
                txtfolcloreSelecionado[1].text = "Curupira";
            }

            else if (idCriaturas == 2)
            {
                txtfolcloreSelecionado[1].text = "Caipora";
            }

            else if (idCriaturas == 3)
            {
                txtfolcloreSelecionado[1].text = "Iara";
            }

            else if (idCriaturas == 4)
            {
                txtfolcloreSelecionado[1].text = "Boto";
            }

            else if (idCriaturas == 5)
            {
                txtfolcloreSelecionado[1].text = "Lobisomem";
            }

            else if (idCriaturas == 6)
            {
                txtfolcloreSelecionado[1].text = "Boitata";
            }

            else if (idCriaturas == 7)
            {
                txtfolcloreSelecionado[1].text = "Mula";
            }

            else if (idCriaturas == 8)
            {
                txtfolcloreSelecionado[1].text = "Cuca";
            }
            else if (idCriaturas == 10)
            {
                txtfolcloreSelecionado[2].text = "Vazio";
            }
        }

        else if (posicaoOcupada[0] == true && posicaoOcupada[1] == true && posicaoOcupada[2] == true)
        {
            if (idCriaturas == 0)
            {
                txtfolcloreSelecionado[2].text = "Saci";
            }

            else if (idCriaturas == 1)
            {
                txtfolcloreSelecionado[2].text = "Curupira";
            }

            else if (idCriaturas == 2)
            {
                txtfolcloreSelecionado[2].text = "Caipora";
            }

            else if (idCriaturas == 3)
            {
                txtfolcloreSelecionado[2].text = "Iara";
            }

            else if (idCriaturas == 4)
            {
                txtfolcloreSelecionado[2].text = "Boto";
            }

            else if (idCriaturas == 5)
            {
                txtfolcloreSelecionado[2].text = "Lobisomem";
            }

            else if (idCriaturas == 6)
            {
                txtfolcloreSelecionado[2].text = "Boitata";
            }

            else if (idCriaturas == 7)
            {
                txtfolcloreSelecionado[2].text = "Mula";
            }

            else if (idCriaturas == 8)
            {
                txtfolcloreSelecionado[2].text = "Cuca";
            }         
        }

    }

    public void Resetar()
    {
        idCriaturas = 10;

        txtfolcloreSelecionado[0].text = "Vazio";
        txtfolcloreSelecionado[1].text = "Vazio";
        txtfolcloreSelecionado[2].text = "Vazio";

        posicaoOcupada[0] = false;
        posicaoOcupada[1] = false;
        posicaoOcupada[2] = false;

        criaturaAtivada[0] = false;
        criaturaAtivada[1] = false;
        criaturaAtivada[2] = false;
        criaturaAtivada[3] = false;
        criaturaAtivada[4] = false;
        criaturaAtivada[5] = false;
        criaturaAtivada[6] = false;
        criaturaAtivada[7] = false;
        criaturaAtivada[8] = false;

        posicaoCompleta = false;

        painelCriaturas[0].SetActive(true);
  
        painelSobreCriaturas[0].SetActive(false);
        painelSobreCriaturas[1].SetActive(false);
        painelSobreCriaturas[2].SetActive(false);
        painelSobreCriaturas[3].SetActive(false);
        painelSobreCriaturas[4].SetActive(false);
        painelSobreCriaturas[5].SetActive(false);
        painelSobreCriaturas[6].SetActive(false);
        painelSobreCriaturas[7].SetActive(false);
        painelSobreCriaturas[8].SetActive(false);
        

        statusPainel = 0;
    }
}


   