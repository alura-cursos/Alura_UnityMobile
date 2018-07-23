using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegueMouse : MonoBehaviour {

	private void Update () {
        var posicao = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = posicao;
	}
}
