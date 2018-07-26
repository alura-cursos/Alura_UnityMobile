using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaPontuacao : MonoBehaviour {
    [SerializeField]
    private TextoDinamico textoPontuacao;

    private Pontuacao pontuacao;
	
	private void Start () {
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
        var totalDePontos = -1;
        if(this.pontuacao  != null)
        {
            totalDePontos = this.pontuacao.Pontos;
        }
        this.textoPontuacao.AtualizarTexto(totalDePontos);
	}
	
	
}
