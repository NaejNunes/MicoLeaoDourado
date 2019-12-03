using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatalhaControle : MonoBehaviour
{
    public int idBotoes;
    public bool BotaoEscolhido;
    public GameObject[] botoes;
    public Text[] txtCriaturas;

    // Start is called before the first frame update
    void Start()
    {
        idBotoes = 0;
    }

    // Update is called once per frame
    void Update()
    {
        NavegarAcoes();
        InstanciarCriaturas();
    }

    public void InstanciarCriaturas()
    {
        txtCriaturas[0].text = "" + PlayerPrefs.GetString("PosicaoUm");
        txtCriaturas[1].text = "" + PlayerPrefs.GetString("PosicaoDois");
        txtCriaturas[2].text = "" + PlayerPrefs.GetString("PosicaoTres");

        txtCriaturas[3].text = "Jogador";
    }

    public void NavegarAcoes()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            idBotoes++;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            idBotoes--;
        }

        //  Condição para o botão voltar para onde estava caso ele tente subir para um que não exista.
        if (idBotoes > 2)
        {
            idBotoes = 2;
        }

        if (idBotoes < 0)
        {
            idBotoes = 0;
        }

        switch (idBotoes)
        {
            case 0:
                botoes[0].GetComponent<Image>().color = Color.green;
                botoes[1].GetComponent<Image>().color = Color.blue;
                botoes[2].GetComponent<Image>().color = Color.blue;

                break;

            case 1:
                botoes[0].GetComponent<Image>().color = Color.blue;
                botoes[1].GetComponent<Image>().color = Color.green;
                botoes[2].GetComponent<Image>().color = Color.blue;

                break;

            case 2:
                botoes[0].GetComponent<Image>().color = Color.blue;
                botoes[1].GetComponent<Image>().color = Color.blue;
                botoes[2].GetComponent<Image>().color = Color.green;
                break;
        }
    }
}
