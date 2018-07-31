using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Ranking : MonoBehaviour, IEnumerable<int>{
    private static string NOME_DO_ARQUIVO = "Ranking.json";
    [SerializeField]
    private List<int> pontos;

    private string caminhoParaOArquivo;

    private void Awake () {
        this.caminhoParaOArquivo = Path.Combine(Application.persistentDataPath,
           NOME_DO_ARQUIVO);
        var textoJson = File.ReadAllText(this.caminhoParaOArquivo);
        JsonUtility.FromJsonOverwrite(textoJson, this);
	}
	
	public void AdicionarPontuacao(int pontos)
    {
        this.pontos.Add(pontos);
        this.SalvarRanking();
    }
    
    public int Quantidade()
    {

        return this.pontos.Count;
    }
    private void SalvarRanking()
    {
        //Como irei salvar o ranking?
        var textoJson = JsonUtility.ToJson(this);
        File.WriteAllText(this.caminhoParaOArquivo, textoJson);
    }

    public IEnumerator<int> GetEnumerator()
    {
        return this.pontos.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.pontos.GetEnumerator();
    }
}
