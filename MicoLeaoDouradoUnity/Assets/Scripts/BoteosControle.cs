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

    public void SelecionarSaciPerere()
    {
         botaoSelecionado[0] = !botaoSelecionado[0];

        if (botaoSelecionado[0] == true)
        {
            controladorFolclore.saci = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if(botaoSelecionado[0] == false)
        {
            controladorFolclore.saci = false;
        }
    }

    public void SelecionarCurupira()
    {
        botaoSelecionado[1] = !botaoSelecionado[1];

        if (botaoSelecionado[1] == true)
        {
            controladorFolclore.curupira = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[1] == false)
        {
            controladorFolclore.curupira = false;
        }
    }

    public void SelecionarCaipora()
    {
        botaoSelecionado[2] = !botaoSelecionado[2];

        if (botaoSelecionado[2] == true)
        {
            controladorFolclore.caipora = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[2] == false)
        {
            controladorFolclore.caipora = false;
        }
    }

    public void SelecionarIara()
    {
        botaoSelecionado[3] = !botaoSelecionado[3];

        if (botaoSelecionado[3] == true)
        {
            controladorFolclore.iara = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[3] == false)
        {
            controladorFolclore.iara = false;
        }
    }

    public void SelecionarBotoCorDeRosa()
    {
        botaoSelecionado[4] = !botaoSelecionado[4];

        if (botaoSelecionado[4] == true)
        {
            controladorFolclore.boto = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[4] == false)
        {
            controladorFolclore.boto = false;
        }
    }

    public void SelecionarLobisomem()
    {
        botaoSelecionado[5] = !botaoSelecionado[5];

        if (botaoSelecionado[5] == true)
        {
            controladorFolclore.lobisomem = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[5] == false)
        {
            controladorFolclore.lobisomem = false;
        }
    }

    public void SelecionarBoitata()
    {
        botaoSelecionado[6] = !botaoSelecionado[6];

        if (botaoSelecionado[6] == true)
        {
            controladorFolclore.boitata = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[6] == false)
        {
            controladorFolclore.boitata = false;
        }
    }

    public void SelecionarMulaSemCabeca()
    {
        botaoSelecionado[7] = !botaoSelecionado[7];

        if (botaoSelecionado[7] == true)
        {
            controladorFolclore.mula = true;
            controladorFolclore.AdicionarFolclores();
        }
        else if (botaoSelecionado[7] == false)
        {
            controladorFolclore.mula = false;
        }
    }

    public void SelecionarCuca()
    {
        botaoSelecionado[8] = !botaoSelecionado[8];

        if (botaoSelecionado[8] == true)
        {
            controladorFolclore.cuca = true;
            controladorFolclore.AdicionarFolclores();

        }
        else if (botaoSelecionado[8] == false)
        {
            controladorFolclore.cuca = false;
        }
    }
}
