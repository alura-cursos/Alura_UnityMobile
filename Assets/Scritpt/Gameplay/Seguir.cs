using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour {

    [SerializeField]
    private Transform alvo;
    [SerializeField]
    private float velocidade;
	
	private void Update () {
        var deslocamento = alvo.position - this.transform.position;
        deslocamento = deslocamento.normalized;
        deslocamento *= this.velocidade;
        this.transform.position += deslocamento * Time.deltaTime;
    }

    public void SetAlvo(Transform novoAlvo)
    {
        this.alvo = novoAlvo;
    }
}
