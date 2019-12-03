using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.SqliteClient;

public class BDControlador : MonoBehaviour
{
    private IDbConnection conexao;
    private IDbCommand comando;
    private IDataReader leitor;

    private string dbArquivo = "URI=File:BancoMicoLeaoDourado.db";

    // Start is called before the first frame update
    void Start()
    {
        Conexao();

        conexao = new SqliteConnection(dbArquivo);
        comando = conexao.CreateCommand();
        conexao.Open();

       
    }

    private void Conexao()
    {
        conexao = new SqliteConnection(dbArquivo);
        comando = conexao.CreateCommand();
        conexao.Open();
        

    }

    public void CriarFormacao()
    {

    }

    public void ResetarFormacao()
    {

    }
}
