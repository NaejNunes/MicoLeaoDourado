using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoteosControle : MonoBehaviour
{
    public GameObject painelHabilidade, painelPausa;
    public bool estadoPainel;
    public bool[] botaoSelecionado;
    public FolcloreControlador controladorFolclore;

    // Start is called before the first frame update
    void Start()
    {
        estadoPainel = false;

        botaoSelecionado[0] = false;
        botaoSelecionado[1] = false;
        botaoSelecionado[2] = false;
        botaoSelecionado[3] = false;
        botaoSelecionado[4] = false;
        botaoSelecionado[5] = false;
        botaoSelecionado[6] = false;
        botaoSelecionado[7] = false;
        botaoSelecionado[8] = false;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void PainelHabilidade()
    {
        estadoPainel = !estadoPainel;

        if (estadoPainel == true)
        {
            painelHabilidade.SetActive(true);
        }
        else
        {
            painelHabilidade.SetActive(false);
        }
    }

    public void PainelPausa()
    {
        estadoPainel = !estadoPainel;

         if (estadoPainel == true)
        {
            painelPausa.SetActive(true);
        }
        else
        {
             painelPausa.SetActive(false);
        }
    }

    public void SelecionarSaciPerere()
    {
        if (controladorFolclore.posicaoCompleta == false && controladorFolclore.criaturaAtivada[0] == false)
        {
            botaoSelecionado[0] = true;
        }
        
        if (controladorFolclore.statusPainel == 0 && botaoSelecionado[0] == true && controladorFolclore.posicaoCompleta == false|| controladorFolclore.statusPainel == 1 && botaoSelecionado[0] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 2 && botaoSelecionado[0] == true && controladorFolclore.posicaoCompleta == false)
        {
            controladorFolclore.idCriaturas = 0;
            controladorFolclore.criaturaAtivada[0] = true;
            controladorFolclore.statusPainel++;
            controladorFolclore.painelSobreCriaturas[0].SetActive(true);
        }
       
    }

    public void SelecionarCurupira()
    {
        if (controladorFolclore.posicaoCompleta == false && controladorFolclore.criaturaAtivada[1] == false)
        {
            botaoSelecionado[1] = true;
        }


        if (controladorFolclore.statusPainel == 0 && botaoSelecionado[1] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 1 && botaoSelecionado[1] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 2 && botaoSelecionado[1] == true && controladorFolclore.posicaoCompleta == false)
        {
            controladorFolclore.idCriaturas = 1;
            controladorFolclore.criaturaAtivada[1] = true;
            controladorFolclore.statusPainel++;        }
            controladorFolclore.painelSobreCriaturas[1].SetActive(true);

    }

    public void SelecionarCaipora()
    {
        if (controladorFolclore.posicaoCompleta == false && controladorFolclore.criaturaAtivada[2] == false)
        {
            botaoSelecionado[2] = true;
        }


        if (controladorFolclore.statusPainel == 0 && botaoSelecionado[2] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 1 && botaoSelecionado[2] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 2 && botaoSelecionado[2] == true && controladorFolclore.posicaoCompleta == false)
        {
            controladorFolclore.idCriaturas = 2;
            controladorFolclore.criaturaAtivada[2] = true;
            controladorFolclore.statusPainel++;
            controladorFolclore.painelSobreCriaturas[2].SetActive(true);

        }
       
    }

    public void SelecionarIara()
    {
        if (controladorFolclore.posicaoCompleta == false && controladorFolclore.criaturaAtivada[3] == false)
        {
            botaoSelecionado[3] = !botaoSelecionado[3];
        }
        if (controladorFolclore.statusPainel == 0 && botaoSelecionado[3] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 1 && botaoSelecionado[3] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 2 && botaoSelecionado[3] == true && controladorFolclore.posicaoCompleta == false)
        {
            controladorFolclore.idCriaturas = 3;
            controladorFolclore.criaturaAtivada[3] = true;
            controladorFolclore.statusPainel++;
            controladorFolclore.painelSobreCriaturas[3].SetActive(true);           

        }
       
    }
     public void SelecionarBoitata()
    {
        if (controladorFolclore.posicaoCompleta == false && controladorFolclore.criaturaAtivada[6] == false)
        {
            botaoSelecionado[4] = true;
        }

        if (controladorFolclore.statusPainel == 0 && botaoSelecionado[4] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 1 && botaoSelecionado[4] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 2 && botaoSelecionado[4] == true && controladorFolclore.posicaoCompleta == false)
        {
            controladorFolclore.idCriaturas = 4;
            controladorFolclore.criaturaAtivada[4] = true;
            controladorFolclore.statusPainel++;
            controladorFolclore.painelSobreCriaturas[4].SetActive(true);
        }       
    }

    public void SelecionarLobisomem()
    {
        if (controladorFolclore.posicaoCompleta == false && controladorFolclore.criaturaAtivada[5] == false)
        {
            botaoSelecionado[5] = true;
        }

        if (controladorFolclore.statusPainel == 0 && botaoSelecionado[5] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 1 && botaoSelecionado[5] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 2 && botaoSelecionado[5] == true && controladorFolclore.posicaoCompleta == false)
        {
            controladorFolclore.idCriaturas = 5;
            controladorFolclore.criaturaAtivada[5] = true;
            controladorFolclore.statusPainel++;
            controladorFolclore.painelSobreCriaturas[5].SetActive(true);
        }       
    }
     public void SelecionarMulaSemCabeca()
    {
        if (controladorFolclore.posicaoCompleta == false && controladorFolclore.criaturaAtivada[6] == false)
        {
            botaoSelecionado[6] = true;
        }

        if (controladorFolclore.statusPainel == 0 && botaoSelecionado[6] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 1 && botaoSelecionado[6] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 2 && botaoSelecionado[6] == true && controladorFolclore.posicaoCompleta == false)
        {
            controladorFolclore.idCriaturas = 6;
            controladorFolclore.criaturaAtivada[6] = true;
            controladorFolclore.statusPainel++;
            controladorFolclore.painelSobreCriaturas[6].SetActive(true);
        }      
    }
    public void SelecionarBotoCorDeRosa()
    {
        if (controladorFolclore.posicaoCompleta == false && controladorFolclore.criaturaAtivada[7] == false)
        {
            botaoSelecionado[7] = true;
        }

        if (controladorFolclore.statusPainel == 0 && botaoSelecionado[7] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 1 && botaoSelecionado[7] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 2 && botaoSelecionado[7] == true && controladorFolclore.posicaoCompleta == false)
        {
            controladorFolclore.idCriaturas = 7;
            controladorFolclore.criaturaAtivada[7] = true;
            controladorFolclore.statusPainel++;
            controladorFolclore.painelSobreCriaturas[7].SetActive(true);
        }
       
    }

    public void SelecionarCuca()
    {
        if (controladorFolclore.posicaoCompleta == false && controladorFolclore.criaturaAtivada[8] == false)
        {
            botaoSelecionado[8] = true;
        }

        if (controladorFolclore.statusPainel == 0 && botaoSelecionado[8] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 1 && botaoSelecionado[8] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 2 && botaoSelecionado[8] == true && controladorFolclore.posicaoCompleta == false)
        {
            controladorFolclore.idCriaturas = 8;
            controladorFolclore.criaturaAtivada[8] = true;
            controladorFolclore.statusPainel++;
            controladorFolclore.painelSobreCriaturas[8].SetActive(true);
        }
       
    }

    public void ResetarFormacao()
    {
        controladorFolclore.Resetar();

        botaoSelecionado[0] = false;
        botaoSelecionado[1] = false;
        botaoSelecionado[2] = false;
        botaoSelecionado[3] = false;
        botaoSelecionado[4] = false;
        botaoSelecionado[5] = false;
        botaoSelecionado[6] = false;
        botaoSelecionado[7] = false;
        botaoSelecionado[8] = false;
    }
}
