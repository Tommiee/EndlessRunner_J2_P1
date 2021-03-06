﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Break();
            Application.LoadLevel(0);
            return;
        }

        if (other.gameObject.transform.parent)
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        } else
        {
            Destroy(other.gameObject);
        }
    }
}