using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour {

    [SerializeField]
    private Transform alvo;
    [SerializeField]
    private float forca;

    private Rigidbody2D fisica;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate () {
        var deslocamento = alvo.position - this.transform.position;
        deslocamento = deslocamento.normalized;
        deslocamento *= this.forca;
       
        this.fisica.AddForce(deslocamento, ForceMode2D.Force);
    }

    public void SetAlvo(Transform novoAlvo)
    {
        this.alvo = novoAlvo;
    }
}
