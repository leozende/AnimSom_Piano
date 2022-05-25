using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troca : MonoBehaviour
{
    public AudioClip qualSom;
    public AudioSource[] Teclas;

    void OnMouseDown()
    {
        foreach (AudioSource item in Teclas)
        {
            item.clip = qualSom;
        }
    }
}
