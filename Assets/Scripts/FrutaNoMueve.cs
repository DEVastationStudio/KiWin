using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrutaNoMueve : MonoBehaviour
{
    public Renderer ren;

    void OnCollisionEnter(Collision collision)
    {
        ren = GetComponent<Renderer>();
        ren.material.SetColor("_Color", Color.green);
    }
}
