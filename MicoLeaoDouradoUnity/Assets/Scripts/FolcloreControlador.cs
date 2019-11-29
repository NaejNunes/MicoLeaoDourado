using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FolcloreControlador : MonoBehaviour
{
    public int formacaoAtual;
    public Text[] txtfolcloreSelecionado;
    public bool[] posicaoOcupada, criaturas;

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
            if (criaturas[0] == true)
            {
                txtfolcloreSelecionado[0].text = "SaciPerere";
                posicaoOcupada[0] = true;
            }
            else
            
            if (criaturas[1] == true)
            {
                txtfolcloreSelecionado[0].text = "Curupira";
                posicaoOcupada[0] = true;
            }
            else
           

            if (criaturas[2] == true)
            {
                txtfolcloreSelecionado[0].text = "Caipora";
                posicaoOcupada[0] = true;
            }
            else
           

            if (criaturas[3] == true)
            {
                txtfolcloreSelecionado[0].text = "Iara";
                posicaoOcupada[0] = true;
            }
            else
            
            if (criaturas[4] == true)
            {
                txtfolcloreSelecionado[0].text = "BotoCorDeRosa";
                posicaoOcupada[0] = true;
            }
            else
            

            if (criaturas[5] == true)
            {
                txtfolcloreSelecionado[0].text = "Lobisomem";
                posicaoOcupada[0] = true;
            }
            else
            

            if (criaturas[6] == true)
            {
                txtfolcloreSelecionado[0].text = "Boitata";
                posicaoOcupada[0] = true;
            }
            else
            

            if (criaturas[7] == true)
            {
                txtfolcloreSelecionado[0].text = "MulaSemCabeça";
                posicaoOcupada[0] = true;
            }
            else
          
            if (criaturas[8] == true)
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
           
            if (criaturas[0] == true)
            {
                txtfolcloreSelecionado[1].text = "SaciPerere";
                posicaoOcupada[1] = true;
            }
           

            else if (criaturas[1] == true)
            {
                txtfolcloreSelecionado[1].text = "Curupira";
                posicaoOcupada[1] = true;
            }
            else if (criaturas[2] == true)
            {
                txtfolcloreSelecionado[1].text = "Caipora";
                posicaoOcupada[1] = true;
            }

            else if (criaturas[3] == true)
            {
                txtfolcloreSelecionado[1].text = "Iara";
                posicaoOcupada[1] = true;
            }
            else if (criaturas[4] == true)
            {
                txtfolcloreSelecionado[1].text = "BotoCorDeRosa";
                posicaoOcupada[1] = true;
            }
            else if (criaturas[5] == true)
            {
                txtfolcloreSelecionado[1].text = "Lobisomem";
                posicaoOcupada[1] = true;
            }
            else if (criaturas[6] == true)
            {
                txtfolcloreSelecionado[1].text = "Boitata";
                posicaoOcupada[1] = true;
            }
            else if (criaturas[7] == true)
            {
                txtfolcloreSelecionado[1].text = "MulaSemCabeca";
                posicaoOcupada[1] = true;
            }
            else if (criaturas[8] == true)
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
            if (criaturas[0] == true)
            {
                txtfolcloreSelecionado[2].text = "SaciPerere";
                posicaoOcupada[2] = true;
            }
            else if (criaturas[1] == true)
            {
                txtfolcloreSelecionado[2].text = "Curupira";
                posicaoOcupada[2] = true;
            }
            else
            
            if (criaturas[2] == true)
            {
                txtfolcloreSelecionado[2].text = "Caipora";
                posicaoOcupada[2] = true;
            }
            else
           
            if (criaturas[3] == true)
            {
                txtfolcloreSelecionado[2].text = "Iara";
                posicaoOcupada[2] = true;
            }
            else
           
            if (criaturas[4] == true)
            {
                txtfolcloreSelecionado[2].text = "BotoCorDeRosa";
                posicaoOcupada[2] = true;
            }
            else
           

            if (criaturas[5] == true)
            {
                txtfolcloreSelecionado[2].text = "Lobisomem";
                posicaoOcupada[2] = true;
            }
            else
           

            if (criaturas[6] == true)
            {
                txtfolcloreSelecionado[2].text = "Boitata";
                posicaoOcupada[2] = true;
            }
            else
           

            if (criaturas[7] == true)
            {
                txtfolcloreSelecionado[2].text = "MulaSemCabeca";
                posicaoOcupada[2] = true;
            }
            else
           

            if (criaturas[8] == true)
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
