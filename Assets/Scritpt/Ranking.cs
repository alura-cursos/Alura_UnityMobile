using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Ranking : MonoBehaviour {
    private static string NOME_DO_ARQUIVO = "Ranking.json";
    [SerializeField]
    private List<int> pontos;
	
	private void Awake () {
        this.pontos = new List<int>();
	}
	
	public void AdicionarPontuacao(int pontos)
    {
        this.pontos.Add(pontos);
        this.pontos.Add(2);
        this.pontos.Add(4);
        this.SalvarRanking();
    }

    private void SalvarRanking()
    {
        //Como irei salvar o ranking?
        var textoJson = JsonUtility.ToJson(this);
        var caminhoParaOArquivo = Path.Combine(Application.persistentDataPath, NOME_DO_ARQUIVO);
        File.WriteAllText(caminhoParaOArquivo, textoJson);
        Debug.Log(Application.persistentDataPath);
    }
}
