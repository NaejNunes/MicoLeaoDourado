using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoteosControle : MonoBehaviour
{
    public GameObject painelHabilidade;
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

    /*
    public void SelecionarSaciPerere()
    {
         botaoSelecionado[0] = !botaoSelecionado[0];
         controladorFolclore.idEscolhido = 0;

        if (botaoSelecionado[0] == true)
        {
            controladorFolclore.criaturas[controladorFolclore.idEscolhido] = true;   
            controladorFolclore.AdicionarFolclores();
        }
        else if(botaoSelecionado[0] == false)
        {
            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == false && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[0] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

             if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[1] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

             if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == true)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[2] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }
        }
    }

    public void SelecionarCurupira()
    {
        botaoSelecionado[1] = !botaoSelecionado[1];
        controladorFolclore.idEscolhido = 1;

        if (botaoSelecionado[1] == true)
        {
            controladorFolclore.criaturas[controladorFolclore.idEscolhido] = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[1] == false)
        {
            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == false && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[0] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[1] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == true)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[2] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }
        }
    }

    public void SelecionarCaipora()
    {
        botaoSelecionado[2] = !botaoSelecionado[2];
        controladorFolclore.idEscolhido = 2;

        if (botaoSelecionado[2] == true)
        {
            controladorFolclore.criaturas[controladorFolclore.idEscolhido] = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[2] == false)
        {
            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == false && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[0] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[1] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == true)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[2] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }
        }
    }

    public void SelecionarIara()
    {
        botaoSelecionado[3] = !botaoSelecionado[3];
        controladorFolclore.idEscolhido = 3;


        if (botaoSelecionado[3] == true)
        {
            controladorFolclore.criaturas[controladorFolclore.idEscolhido] = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[3] == false)
        {
            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == false && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[0] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[1] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == true)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[2] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }
        }
    }

    public void SelecionarBotoCorDeRosa()
    {
        botaoSelecionado[4] = !botaoSelecionado[4];
        controladorFolclore.idEscolhido = 4;

        if (botaoSelecionado[4] == true)
        {
            controladorFolclore.criaturas[controladorFolclore.idEscolhido] = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[4] == false)
        {
            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == false && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[0] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[1] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == true)
            {
                controladorFolclore.criaturas[4] = false;
                controladorFolclore.posicaoOcupada[2] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }
        }
    }

    public void SelecionarLobisomem()
    {
        botaoSelecionado[5] = !botaoSelecionado[5];
        controladorFolclore.idEscolhido = 5;

        if (botaoSelecionado[5] == true)
        {
            controladorFolclore.criaturas[controladorFolclore.idEscolhido] = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[5] == false)
        {
            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == false && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[0] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[1] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == true)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[2] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }
        }
    }

    public void SelecionarBoitata()
    {
        botaoSelecionado[6] = !botaoSelecionado[6];
        controladorFolclore.idEscolhido = 6;

        if (botaoSelecionado[6] == true)
        {
            controladorFolclore.criaturas[controladorFolclore.idEscolhido] = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[6] == false)
        {
            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == false && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[0] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[1] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == true)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[2] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }
        }
    }

    public void SelecionarMulaSemCabeca()
    {
        botaoSelecionado[7] = !botaoSelecionado[7];
        controladorFolclore.idEscolhido = 7;

        if (botaoSelecionado[7] == true)
        {
            controladorFolclore.criaturas[controladorFolclore.idEscolhido] = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[7] == false)
        {
            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == false && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[0] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[1] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == true)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[2] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }
        }
    }

    public void SelecionarCuca()
    {
        botaoSelecionado[8] = !botaoSelecionado[8];
        controladorFolclore.idEscolhido = 8;

        if (botaoSelecionado[8] == true)
        {
            controladorFolclore.criaturas[controladorFolclore.idEscolhido] = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[8] == false)
        {
            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == false && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[0] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == false)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[1] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }

            if (controladorFolclore.criaturas[controladorFolclore.idEscolhido] == true && controladorFolclore.posicaoOcupada[0] == true && controladorFolclore.posicaoOcupada[1] == true && controladorFolclore.posicaoOcupada[2] == true)
            {
                controladorFolclore.criaturas[controladorFolclore.idEscolhido] = false;
                controladorFolclore.posicaoOcupada[2] = false;
                controladorFolclore.criaturaAtiva[0] = false;
                controladorFolclore.AdicionarFolclores();
            }
        }
    }
    */

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
            controladorFolclore.statusPainel++;
        }
       
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
        }
       
    }

    public void SelecionarBotoCorDeRosa()
    {
        if (controladorFolclore.posicaoCompleta == false && controladorFolclore.criaturaAtivada[4] == false)
        {
            botaoSelecionado[4] = true;
        }

        if (controladorFolclore.statusPainel == 0 && botaoSelecionado[4] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 1 && botaoSelecionado[4] == true && controladorFolclore.posicaoCompleta == false || controladorFolclore.statusPainel == 2 && botaoSelecionado[4] == true && controladorFolclore.posicaoCompleta == false)
        {
            controladorFolclore.idCriaturas = 4;
            controladorFolclore.criaturaAtivada[4] = true;
            controladorFolclore.statusPainel++;
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
        }
       
    }

    public void SelecionarBoitata()
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
        }
       
    }

    public void SelecionarMulaSemCabeca()
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
