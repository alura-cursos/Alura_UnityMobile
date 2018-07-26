using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDePause : MonoBehaviour {

    [SerializeField]
    private GameObject painelPause;
    [SerializeField, Range(0,1)]
    private float escalaDeTempoDuranteOPause;

    private void Update () {
        if (this.EstaoTocandoNaTela())
        {
            this.ContinuarJogo();
        }
        else
        {
            this.PararJogo();
        }
	}

    private void ContinuarJogo()
    {
        this.painelPause.SetActive(false);
        this.MudarEscalaDeTempo(1);
    }

    private void PararJogo()
    {
        this.painelPause.SetActive(true);
        this.MudarEscalaDeTempo(this.escalaDeTempoDuranteOPause);
    }

    private bool EstaoTocandoNaTela()
    {
        return Input.touchCount > 0;
    }

    private void MudarEscalaDeTempo(float escala)
    {
        Time.timeScale = escala;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}
