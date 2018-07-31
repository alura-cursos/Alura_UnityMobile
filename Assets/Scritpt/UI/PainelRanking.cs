using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PainelRanking : MonoBehaviour {
    [SerializeField]
    private Ranking ranking;
    [SerializeField]
    private GameObject prefabColocado;
	
	private void Start () {
        var quantidade = this.ranking.Quantidade();
        var colocacao = 1;
        foreach(var ponto in this.ranking)
        {
            if(colocacao > 5)
            {
                break;
            }
            //criar um colocado
            var colocado = GameObject.Instantiate(this.prefabColocado, this.transform);
            colocado.GetComponent<ItemRanking>().Configurar(colocacao, "Ricardo", ponto);
            colocacao++;
        }
	}
}
