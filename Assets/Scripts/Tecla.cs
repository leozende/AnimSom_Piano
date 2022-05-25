using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tecla : MonoBehaviour
{

    public string tecla;

    void Update()
    {
        if (!tecla.Equals(""))
        {
            if (Input.GetKeyDown(tecla))
                GetComponent<AudioSource>().Play();
        }
    }

    void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
    }
}
