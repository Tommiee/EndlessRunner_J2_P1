using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_BackGround : MonoBehaviour
{

    public float speed = 0.5f;
    public Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        float offset = Time.time * speed;

        rend.material.mainTextureOffset = new Vector2(offset, 0);
    }
}