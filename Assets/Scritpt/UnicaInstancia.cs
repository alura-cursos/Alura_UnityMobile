using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicaInstancia : MonoBehaviour
{
    private void Start()
    {
        var outros = GameObject.FindGameObjectsWithTag(this.tag);

        for (var i = 0; i < outros.Length; i++)
        {
            var outro = outros[i];

            if (outro != this.gameObject)
            {
                GameObject.Destroy(outro);
            }
        }
    }
}