using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDePause : MonoBehaviour
{

    [SerializeField]
    private GameObject painelPause;
    [SerializeField, Range(0, 1)]
    private float escalaDeTempoDuranteOPause;

    private bool jogoEstaParado;
    private void Update()
    {
        if (this.EstaoTocandoNaTela())
        {
            if (this.jogoEstaParado)
            {
                this.ContinuarJogo();
            }
        }
        else
        {
            if (!this.jogoEstaParado)
            {
                this.PararJogo();
            }
        }
    }

    private void ContinuarJogo()
    {
        StartCoroutine(this.EsperarEContinuarOJogo());
    }

    private IEnumerator EsperarEContinuarOJogo()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        this.MudarEscalaDeTempo(1);
        this.painelPause.SetActive(false);
        this.jogoEstaParado = false;
    }

    private void PararJogo()
    {
        this.painelPause.SetActive(true);
        this.MudarEscalaDeTempo(this.escalaDeTempoDuranteOPause);
        this.jogoEstaParado = true;
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
