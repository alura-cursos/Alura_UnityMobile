using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pontuavel : MonoBehaviour {

    private Pontuacao pontuacao;

	public void Pontuar()
    {
        this.pontuacao.Pontuar();
    }

    public void SetPontuacao(Pontuacao pontuacao)
    {
        this.pontuacao = pontuacao;
    }
}
