using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemRanking : MonoBehaviour {
    [SerializeField]
    private Text textoColocacao;
    [SerializeField]
    private Text textoNome;
    [SerializeField]
    private Text textoPontuacao;
   
    public void Configurar(int colocacao, string nome, int pontucao)
    {
        this.textoColocacao.text = colocacao.ToString();
        this.textoNome.text = nome;
        this.textoPontuacao.text = pontucao.ToString();
    }
}
