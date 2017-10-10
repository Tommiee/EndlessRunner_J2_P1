using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_ChangeColour : MonoBehaviour {

    [SerializeField]
    private Material mat;

	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine("Fade");
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            StopCoroutine("Fade");
        }
    }

    private IEnumerator Fade()
    {
        for (float i = 1; i > 0; i -= 0.01f)
        {
            mat.color = new Color(i * 9, i, i * 9);
            yield return null;
        }
    }
}