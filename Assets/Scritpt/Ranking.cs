using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Collections.ObjectModel;
using System;

public class Ranking : MonoBehaviour {
    private static string NOME_DO_ARQUIVO = "Ranking.json";
    [SerializeField]
    private List<Colocado> listaDeColocados;

    private string caminhoParaOArquivo;

    private void Awake () {
        this.caminhoParaOArquivo = Path.Combine(Application.persistentDataPath,
           NOME_DO_ARQUIVO);
        if (File.Exists(this.caminhoParaOArquivo))
        {
            var textoJson = File.ReadAllText(this.caminhoParaOArquivo);
            JsonUtility.FromJsonOverwrite(textoJson, this);
        }
        else
        {
            this.listaDeColocados = new List<Colocado>();
        }
       
	}
	
	public int AdicionarPontuacao(int pontos, string nome)
    {
        var id = this.listaDeColocados.Count * UnityEngine.Random.Range(1, 100000);
        var novoColocado = new Colocado(nome, pontos, id);
        this.listaDeColocados.Add(novoColocado);
        this.listaDeColocados.Sort();
        this.SalvarRanking();
        return id;
    }
    
    public void AlterarNome(string novoNome, int id)
    {
        foreach (var item in this.listaDeColocados)
        {
            if(item.id == id)
            {
                item.nome = novoNome;
                break;
            }
        }
        this.SalvarRanking();
    }
    public int Quantidade()
    {
        return this.listaDeColocados.Count;
    }

    public ReadOnlyCollection<Colocado> GetColocados()
    {
        return this.listaDeColocados.AsReadOnly();
    }
    
    private void SalvarRanking()
    {
        //Como irei salvar o ranking?
        var textoJson = JsonUtility.ToJson(this, true);
        File.WriteAllText(this.caminhoParaOArquivo, textoJson);
    }
}
[System.Serializable]
public class Colocado:IComparable
{
    public string nome;
    public int pontos;
    public int id;

    public Colocado(string nome, int pontos, int id)
    {
        this.nome = nome;
        this.pontos = pontos;
        this.id = id;
    }

    public int CompareTo(object obj)
    {
        //-1 Se eu venho antes do outro objeto
        //0 se eu tenho a mesma posicao do outro objeto
        //1 se eu venho depois do outro objeto

        var outroObjeto = obj as Colocado;
        return outroObjeto.pontos.CompareTo(this.pontos);
    }
}