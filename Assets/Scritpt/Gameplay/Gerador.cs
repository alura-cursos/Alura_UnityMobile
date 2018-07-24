using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gerador : MonoBehaviour
{
    [SerializeField]
    private Transform alvo;
    [SerializeField]
    private GameObject prefabInimigo;
    [SerializeField]
    private float tempo;
    [SerializeField]
    private float raio;
    
    private void Start()
    {
        InvokeRepeating("Instanciar", 0f, this.tempo);
    }

    private void Instanciar()
    {
        var inimigo = GameObject.Instantiate(this.prefabInimigo);
        this.DefinirPosicaoInimigo(inimigo);
        inimigo.GetComponent<Seguir>().SetAlvo(this.alvo);
    }

    private void DefinirPosicaoInimigo(GameObject inimigo)
    {
        var posicaoAleatoria = Random.insideUnitCircle * this.raio;
        var posicaoInimigo = (Vector2)this.transform.position + posicaoAleatoria;
        inimigo.transform.position = posicaoInimigo;
    }
}
