using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscolhaDeCriaturas : MonoBehaviour
{
    public int statusPainel;
    public int[]  posicaoUm, posicaoDois, posicaoTres;
    public int idCriaturas, IdGrupoCheio;
    public GameObject[] imgCriaturas, painelSelecionada;
    public bool grupoCheio;
    public int sexo;
    // Start is called before the first frame update

    private void Awake()
    {
        CarregarStatusMenu();
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        IdCriatura();

        if (statusPainel > 3)
        {
            statusPainel = 3;
        }
        if (statusPainel < 1)
        {
            statusPainel = 1;
        }
      
    }

    public void SaciPerere()
    {
        if (grupoCheio == false)
        {
            if (statusPainel == 1 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoUm[0] = 1;
            }
            else if (statusPainel == 2 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoDois[0] = 10;
            }
            else if (statusPainel == 3 && grupoCheio == false)
            {
                grupoCheio = true;
                IdGrupoCheio = 1;
                posicaoTres[0] = 19;
            }

            idCriaturas = 1;
            statusPainel++;
        }       
    }

    public void MulaSemCabeca()
    {
        if (grupoCheio == false)
        {
            if (statusPainel == 1 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoUm[1] = 2;
            }
            else if (statusPainel == 2 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoDois[1] = 11;
            }
            else if (statusPainel == 3 && grupoCheio == false)
            {
                grupoCheio = true;
                IdGrupoCheio = 1;
                posicaoTres[1] = 20;
            }

            idCriaturas = 2;
            statusPainel++;
        }     
    }

    public void Lobisomem()
    {
        if (grupoCheio == false)
        {
            if (statusPainel == 1 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoUm[2] = 3;
            }
            else if (statusPainel == 2 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoDois[2] = 12;
            }
            else if (statusPainel == 3 && grupoCheio == false)
            {
                grupoCheio = true;
                IdGrupoCheio = 1;
                posicaoTres[2] = 21;
            }

            idCriaturas = 3;
            statusPainel++;
        }    
    }

    public void Caipora()
    {
        if (grupoCheio == false)
        {
            if (statusPainel == 1 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoUm[3] = 4;
            }
            else if (statusPainel == 2 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoDois[3] = 13;
            }
            else if (statusPainel == 3 && grupoCheio == false)
            {
                grupoCheio = true;
                IdGrupoCheio = 1;
                posicaoTres[3] = 22;
            }

            idCriaturas = 4;
            statusPainel++;
        }    
    }

    public void Iaia()
    {
        if (grupoCheio == false)
        {
            if (statusPainel == 1 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoUm[4] = 5;
            }
            else if (statusPainel == 2 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoDois[4] = 14;
            }
            else if (statusPainel == 3 && grupoCheio == false)
            {
                grupoCheio = true;
                IdGrupoCheio = 1;
                posicaoTres[4] = 23;
            }

            idCriaturas = 5;
            statusPainel++;
        }
      
    }

    public void Curupira()
    {
        if (grupoCheio == false)
        {
            if (statusPainel == 1 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoUm[5] = 6;
            }
            else if (statusPainel == 2 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoDois[5] = 15;
            }
            else if (statusPainel == 3 && grupoCheio == false)
            {
                grupoCheio = true;
                IdGrupoCheio = 1;
                posicaoTres[5] = 24;
            }

            idCriaturas = 6;
            statusPainel++;
        }      
    }

    public void Cuca()
    {
        if (grupoCheio == false)
        {
            if (statusPainel == 1 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoUm[6] = 7;
            }
            else if (statusPainel == 2 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoDois[6] = 16;
            }
            else if (statusPainel == 3 && grupoCheio == false)
            {
                grupoCheio = true;
                IdGrupoCheio = 1;
                posicaoTres[6] = 25;
            }

            idCriaturas = 7;
            statusPainel++;
        }     
    }

    public void BotoCorDeRosa()
    {
        if (grupoCheio == false)
        {
            if (statusPainel == 1 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoUm[7] = 8;
            }
            else if (statusPainel == 2 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoDois[7] = 17;
            }
            else if (statusPainel == 3 && grupoCheio == false)
            {
                grupoCheio = true;
                IdGrupoCheio = 1;
                posicaoTres[7] = 26;
            }

            idCriaturas = 8;
            statusPainel++;
        }
    }
       
    public void Boitata()
    {
        if (grupoCheio == false)
        {
            if (statusPainel == 1 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoUm[8] = 9;
            }
            else if (statusPainel == 2 && grupoCheio == false)
            {
                IdGrupoCheio = 0;
                posicaoDois[8] = 18;
            }
            else if (statusPainel == 3 && grupoCheio == false)
            {
                grupoCheio = true;
                IdGrupoCheio = 1;
                posicaoTres[8] = 27;
            }

            idCriaturas = 9;
            statusPainel++;
        }      
    }

    public void IdCriatura()
    {
        if (posicaoUm[0] == 1)
        {
            imgCriaturas[0].SetActive(true);
            imgCriaturas[27].SetActive(true);
            painelSelecionada[0].SetActive(true);
        }
        if (posicaoUm[1] == 2)
        {
            imgCriaturas[1].SetActive(true);
            imgCriaturas[28].SetActive(true);
            painelSelecionada[1].SetActive(true);
        }
         if (posicaoUm[2] == 3)
        {
            imgCriaturas[2].SetActive(true);
            imgCriaturas[29].SetActive(true);
            painelSelecionada[2].SetActive(true);
        }
         if (posicaoUm[3] == 4)
        {
            imgCriaturas[3].SetActive(true);
            imgCriaturas[30].SetActive(true);
            painelSelecionada[3].SetActive(true);
        }
         if (posicaoUm[4] == 5)
        {
            imgCriaturas[4].SetActive(true);
            imgCriaturas[31].SetActive(true);
            painelSelecionada[4].SetActive(true);
        }
         if (posicaoUm[5] == 6)
        {
            imgCriaturas[5].SetActive(true);
            imgCriaturas[32].SetActive(true);
            painelSelecionada[5].SetActive(true);
        }
         if (posicaoUm[6] == 7)
        {
            imgCriaturas[6].SetActive(true);
            imgCriaturas[33].SetActive(true);
            painelSelecionada[6].SetActive(true);
        }
         if (posicaoUm[7] == 8)
        {
            imgCriaturas[7].SetActive(true);
            imgCriaturas[34].SetActive(true);
            painelSelecionada[7].SetActive(true);
        }
         if (posicaoUm[8] == 9)
        {
            imgCriaturas[8].SetActive(true);
            imgCriaturas[35].SetActive(true);
            painelSelecionada[8].SetActive(true);
        }
         if (posicaoDois[0] == 10)
        {
            imgCriaturas[9].SetActive(true);
            imgCriaturas[36].SetActive(true);
            painelSelecionada[0].SetActive(true);
        }
         if (posicaoDois[1] == 11)
        {
            imgCriaturas[10].SetActive(true);
            imgCriaturas[37].SetActive(true);
            painelSelecionada[1].SetActive(true);
        }
         if (posicaoDois[2] == 12)
        {
            imgCriaturas[11].SetActive(true);
            imgCriaturas[38].SetActive(true);
            painelSelecionada[2].SetActive(true);
        }
         if (posicaoDois[3] == 13)
        {
            imgCriaturas[12].SetActive(true);
            imgCriaturas[39].SetActive(true);
            painelSelecionada[3].SetActive(true);
        }
         if (posicaoDois[4] == 14)
        {
            imgCriaturas[13].SetActive(true);
            imgCriaturas[40].SetActive(true);
            painelSelecionada[4].SetActive(true);
        }
         if (posicaoDois[5] == 15)
        {
            imgCriaturas[14].SetActive(true);
            imgCriaturas[41].SetActive(true);
            painelSelecionada[5].SetActive(true);
        }
         if (posicaoDois[6] == 16)
        {
            imgCriaturas[15].SetActive(true);
            imgCriaturas[42].SetActive(true);
            painelSelecionada[6].SetActive(true);
        }
         if (posicaoDois[7] == 17)
        {
            imgCriaturas[16].SetActive(true);
            imgCriaturas[43].SetActive(true);
            painelSelecionada[7].SetActive(true);
        }
         if (posicaoDois[8] == 18)
        {
            imgCriaturas[17].SetActive(true);
            imgCriaturas[44].SetActive(true);
            painelSelecionada[8].SetActive(true);
        }
         if (posicaoTres[0] == 19)
        {
            imgCriaturas[18].SetActive(true);
            imgCriaturas[45].SetActive(true);
            painelSelecionada[0].SetActive(true);
        }
         if (posicaoTres[1] == 20)
        {
            imgCriaturas[19].SetActive(true);
            imgCriaturas[46].SetActive(true);
            painelSelecionada[1].SetActive(true);
        }
         if (posicaoTres[2] == 21)
        {
            imgCriaturas[20].SetActive(true);
            imgCriaturas[47].SetActive(true);
            painelSelecionada[2].SetActive(true);
        }
         if (posicaoTres[3] == 22)
        {
            imgCriaturas[21].SetActive(true);
            imgCriaturas[48].SetActive(true);
            painelSelecionada[3].SetActive(true);
        }
         if (posicaoTres[4] == 23)
        {
            imgCriaturas[22].SetActive(true);
            imgCriaturas[49].SetActive(true);
            painelSelecionada[4].SetActive(true);
        }
         if (posicaoTres[5] == 24)
        {
            imgCriaturas[23].SetActive(true);
            imgCriaturas[50].SetActive(true);
            painelSelecionada[5].SetActive(true);
        }
         if (posicaoTres[6] == 25)
        {
            imgCriaturas[24].SetActive(true);
            imgCriaturas[51].SetActive(true);
            painelSelecionada[6].SetActive(true);
        }
         if (posicaoTres[7] == 26)
        {
            imgCriaturas[25].SetActive(true);
            imgCriaturas[52].SetActive(true);
            painelSelecionada[7].SetActive(true);

        }
         if (posicaoTres[8] == 27)
        {
            imgCriaturas[26].SetActive(true);
            imgCriaturas[53].SetActive(true);
            painelSelecionada[8].SetActive(true);
        }

        if (IdGrupoCheio == 1)
        {
            grupoCheio = true;
        }
        else
        {
            grupoCheio = false;
        }
    }

    public void ResetarSelecao()
    {
        statusPainel = 0;
        grupoCheio = false;
        IdGrupoCheio = 0;

        //DESATIVAR CRIATURAS SELECIONADAS
        for (int i = 0; i < 54; i++)
        {
            imgCriaturas[i].SetActive(false);
        }

        //DESATIVA
        for (int j = 0; j < 9; j++)
        {
            painelSelecionada[j].SetActive(false);
            posicaoUm[j] = 0;
            posicaoDois[j] = 0;
            posicaoTres[j] = 0;
        }
    }

    public void CarregarStatusMenu()
    {
       statusPainel = PlayerPrefs.GetInt("StatusPainel");
       idCriaturas = PlayerPrefs.GetInt("IdCriaturas");
       IdGrupoCheio = PlayerPrefs.GetInt("GrupoCheio");
       
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
}
