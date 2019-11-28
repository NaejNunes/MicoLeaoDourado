using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FolcloreControlador : MonoBehaviour
{
    public int formacaoAtual;
    public Text[] txtfolcloreSelecionado;
    public bool[] posicaoOcupada;
    public bool saci, curupira, caipora, mula, lobisomem, boitata, iara, boto, cuca;

    // Start is called before the first frame update
    void Start()
    {
        posicaoOcupada[0] = false;
        posicaoOcupada[1] = false;
        posicaoOcupada[2] = false;             
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AdicionarFolclores()
    {
        if (posicaoOcupada[0] == false && posicaoOcupada[1] == false && posicaoOcupada[2] == false)
        {
            if (saci == true)
            {
                txtfolcloreSelecionado[0].text = "SaciPerere";
                posicaoOcupada[0] = true;
            }
            else
            {
                txtfolcloreSelecionado[0].text = "Vazio";
                posicaoOcupada[0] = false;

            }

            if (curupira == true)
            {
                txtfolcloreSelecionado[0].text = "Curupira";
                posicaoOcupada[0] = true;
            }
            else
            {
                txtfolcloreSelecionado[0].text = "Vazio";
                posicaoOcupada[0] = false;
            }

            if (caipora == true)
            {
                txtfolcloreSelecionado[0].text = "Caipora";
                posicaoOcupada[0] = true;
            }
            else
            {
                txtfolcloreSelecionado[0].text = "Vazio";
                posicaoOcupada[0] = false;
            }

            if (iara == true)
            {
                txtfolcloreSelecionado[0].text = "Iara";
                posicaoOcupada[0] = true;
            }
            else
            {
                txtfolcloreSelecionado[0].text = "Vazio";
                posicaoOcupada[0] = false;
            }

            if (boto == true)
            {
                txtfolcloreSelecionado[0].text = "BotoCorDeRosa";
                posicaoOcupada[0] = true;
            }
            else
            {
                txtfolcloreSelecionado[0].text = "Vazio";
                posicaoOcupada[0] = false;
            }

            if (lobisomem == true)
            {
                txtfolcloreSelecionado[0].text = "Lobisomem";
                posicaoOcupada[0] = true;
            }
            else
            {
                txtfolcloreSelecionado[0].text = "Vazio";
                posicaoOcupada[0] = false;
            }

            if (boitata == true)
            {
                txtfolcloreSelecionado[0].text = "Boitata";
                posicaoOcupada[0] = true;
            }
            else
            {
                txtfolcloreSelecionado[0].text = "Vazio";
                posicaoOcupada[0] = false;
            }

            if (mula == true)
            {
                txtfolcloreSelecionado[0].text = "MulaSemCabeça";
                posicaoOcupada[0] = true;
            }
            else
            {
                txtfolcloreSelecionado[0].text = "Vazio";
                posicaoOcupada[0] = false;
            }

            if (cuca == true)
            {
                txtfolcloreSelecionado[0].text = "Cuca";
                posicaoOcupada[0] = true;
            }
            else
            {
                txtfolcloreSelecionado[0].text = "Vazio";
                posicaoOcupada[0] = false;
            }
            
        }

        else if (posicaoOcupada[0] == true && posicaoOcupada[1] == false && posicaoOcupada[2] == false)
        {
            if (saci == true)
            {
                txtfolcloreSelecionado[1].text = "SaciPerere";
                posicaoOcupada[1] = true;
            }
            else
            {
                txtfolcloreSelecionado[1].text = "Vazio";
                posicaoOcupada[1] = false;
            }

            if (curupira == true)
            {
                txtfolcloreSelecionado[1].text = "Curupira";
                posicaoOcupada[1] = true;
            }
            else
            {
                txtfolcloreSelecionado[1].text = "Vazio";
                posicaoOcupada[1] = false;
            }

            if (caipora == true)
            {
                txtfolcloreSelecionado[1].text = "Caipora";
                posicaoOcupada[1] = true;
            }
            else
            {
                txtfolcloreSelecionado[1].text = "Vazio";
                posicaoOcupada[1] = false;
            }

            if (iara == true)
            {
                txtfolcloreSelecionado[1].text = "Iara";
                posicaoOcupada[1] = true;
            }
            else
            {
                txtfolcloreSelecionado[1].text = "Vazio";
                posicaoOcupada[1] = false;
            }

            if (boto == true)
            {
                txtfolcloreSelecionado[1].text = "BotoCorDeRosa";
                posicaoOcupada[1] = true;
            }
            else
            {
                txtfolcloreSelecionado[1].text = "Vazio";
                posicaoOcupada[1] = false;
            }

            if (lobisomem == true)
            {
                txtfolcloreSelecionado[1].text = "Lobisomem";
                posicaoOcupada[1] = true;
            }
            else
            {
                txtfolcloreSelecionado[1].text = "Vazio";
                posicaoOcupada[1] = false;
            }

            if (boitata == true)
            {
                txtfolcloreSelecionado[1].text = "Boitata";
                posicaoOcupada[1] = true;
            }
            else
            {
                txtfolcloreSelecionado[1].text = "Vazio";
                posicaoOcupada[1] = false;
            }

            if (mula == true)
            {
                txtfolcloreSelecionado[1].text = "MulaSemCabeca";
                posicaoOcupada[1] = true;
            }
            else
            {
                txtfolcloreSelecionado[1].text = "Vazio";
                posicaoOcupada[1] = false;
            }

            if (cuca == true)
            {
                txtfolcloreSelecionado[1].text = "Cuca";
                posicaoOcupada[1] = true;
            }
            else
            {
                txtfolcloreSelecionado[1].text = "Vazio";
                posicaoOcupada[1] = false;
            }
        }

        else if (posicaoOcupada[0] == true && posicaoOcupada[1] == true && posicaoOcupada[2] == false)
        {
            if (saci == true)
            {
                txtfolcloreSelecionado[2].text = "SaciPerere";
                posicaoOcupada[2] = true;
            }
            else
            {
                txtfolcloreSelecionado[2].text = "Vazio";
                posicaoOcupada[2] = false;
            }

            if (curupira == true)
            {
                txtfolcloreSelecionado[2].text = "Curupira";
                posicaoOcupada[2] = true;
            }
            else
            {
                txtfolcloreSelecionado[2].text = "Vazio";
                posicaoOcupada[2] = false;
            }

            if (caipora == true)
            {
                txtfolcloreSelecionado[2].text = "Caipora";
                posicaoOcupada[2] = true;
            }
            else
            {
                txtfolcloreSelecionado[2].text = "Vazio";
                posicaoOcupada[2] = false;
            }

            if (iara == true)
            {
                txtfolcloreSelecionado[2].text = "Iara";
                posicaoOcupada[2] = true;
            }
            else
            {
                txtfolcloreSelecionado[2].text = "Vazio";
                posicaoOcupada[2] = false;
            }

            if (boto == true)
            {
                txtfolcloreSelecionado[2].text = "BotoCorDeRosa";
                posicaoOcupada[2] = true;
            }
            else
            {
                txtfolcloreSelecionado[2].text = "Vazio";
                posicaoOcupada[2] = false;
            }

            if (lobisomem == true)
            {
                txtfolcloreSelecionado[2].text = "Lobisomem";
                posicaoOcupada[2] = true;
            }
            else
            {
                txtfolcloreSelecionado[2].text = "Vazio";
                posicaoOcupada[2] = false;
            }

            if (boitata == true)
            {
                txtfolcloreSelecionado[2].text = "Boitata";
                posicaoOcupada[2] = true;
            }
            else
            {
                txtfolcloreSelecionado[2].text = "Vazio";
                posicaoOcupada[2] = false;
            }

            if (mula == true)
            {
                txtfolcloreSelecionado[2].text = "MulaSemCabeca";
                posicaoOcupada[2] = true;
            }
            else
            {
                txtfolcloreSelecionado[2].text = "Vazio";
                posicaoOcupada[2] = false;
            }

            if (cuca == true)
            {
                txtfolcloreSelecionado[2].text = "Cuca";
                posicaoOcupada[2] = true;
            }
            else
            {
                txtfolcloreSelecionado[2].text = "Vazio";
                posicaoOcupada[2] = false;
            }
        }
    }
}
