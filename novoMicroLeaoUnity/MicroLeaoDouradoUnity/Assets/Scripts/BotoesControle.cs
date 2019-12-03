using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesControle : MonoBehaviour
{
    public EscolhaDeCriaturas criaturasControle;
    public int sexo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SalvarStatusMenu()
    {
        PlayerPrefs.SetInt("StatusPainel", criaturasControle.statusPainel);
        PlayerPrefs.SetInt("IdCriaturas", criaturasControle.idCriaturas);
        PlayerPrefs.SetInt("GrupoCheio", criaturasControle.IdGrupoCheio);

        PlayerPrefs.SetInt("Folclore0", criaturasControle.posicaoUm[0]);
        PlayerPrefs.SetInt("Folclore1", criaturasControle.posicaoUm[1]);
        PlayerPrefs.SetInt("Folclore2", criaturasControle.posicaoUm[2]);
        PlayerPrefs.SetInt("Folclore3", criaturasControle.posicaoUm[3]);
        PlayerPrefs.SetInt("Folclore4", criaturasControle.posicaoUm[4]);
        PlayerPrefs.SetInt("Folclore5", criaturasControle.posicaoUm[5]);
        PlayerPrefs.SetInt("Folclore6", criaturasControle.posicaoUm[6]);
        PlayerPrefs.SetInt("Folclore7", criaturasControle.posicaoUm[7]);
        PlayerPrefs.SetInt("Folclore8", criaturasControle.posicaoUm[8]);
        PlayerPrefs.SetInt("Folclore9", criaturasControle.posicaoDois[0]);
        PlayerPrefs.SetInt("Folclore10", criaturasControle.posicaoDois[1]);
        PlayerPrefs.SetInt("Folclore11", criaturasControle.posicaoDois[2]);
        PlayerPrefs.SetInt("Folclore12", criaturasControle.posicaoDois[3]);
        PlayerPrefs.SetInt("Folclore13", criaturasControle.posicaoDois[4]);
        PlayerPrefs.SetInt("Folclore14", criaturasControle.posicaoDois[5]);
        PlayerPrefs.SetInt("Folclore15", criaturasControle.posicaoDois[6]);
        PlayerPrefs.SetInt("Folclore16", criaturasControle.posicaoDois[7]);
        PlayerPrefs.SetInt("Folclore17", criaturasControle.posicaoDois[8]);
        PlayerPrefs.SetInt("Folclore18", criaturasControle.posicaoTres[0]);
        PlayerPrefs.SetInt("Folclore19", criaturasControle.posicaoTres[1]);
        PlayerPrefs.SetInt("Folclore20", criaturasControle.posicaoTres[2]);
        PlayerPrefs.SetInt("Folclore21", criaturasControle.posicaoTres[3]);
        PlayerPrefs.SetInt("Folclore22", criaturasControle.posicaoTres[4]);
        PlayerPrefs.SetInt("Folclore23", criaturasControle.posicaoTres[5]);
        PlayerPrefs.SetInt("Folclore24", criaturasControle.posicaoTres[6]);
        PlayerPrefs.SetInt("Folclore25", criaturasControle.posicaoTres[7]);
        PlayerPrefs.SetInt("Folclore26", criaturasControle.posicaoTres[8]);
    }

    public void EscolhaMenina()
    {
        sexo = 1;
        PlayerPrefs.SetInt("Sexo", sexo);
        SceneManager.LoadScene("Mundo");
    }

    public void EscolhaMenino()
    {
        sexo = 2;
        PlayerPrefs.SetInt("Sexo", sexo);
        SceneManager.LoadScene("Mundo");
    }

    public void CenaBatalha()
    {
        SceneManager.LoadScene("Batalha");
    }
}