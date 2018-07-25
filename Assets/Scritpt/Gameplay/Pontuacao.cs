using System;
using UnityEngine;
using UnityEngine.Events;

public class Pontuacao : MonoBehaviour {

    [SerializeField]
    private MeuEventoPersonalizadoInt aoPontuar;

    private int pontos;

    public void Pontuar()
    {
        this.pontos++;
        this.aoPontuar.Invoke(this.pontos);
    }
}

[Serializable]
public class MeuEventoPersonalizadoInt : UnityEvent<int>
{

}