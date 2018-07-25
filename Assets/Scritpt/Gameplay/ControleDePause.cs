using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDePause : MonoBehaviour {

    [SerializeField]
    private GameObject painelPause;

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
        
    }

    private void PararJogo()
    {
        this.painelPause.SetActive(true);
        
    }

    private bool EstaoTocandoNaTela()
    {
        return Input.touchCount > 0;
    }
}
