using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrutaNoMueve : MonoBehaviour
{
    [SerializeField] private GameTimerController timer;
    public Renderer ren;
    public PlayerScore score;

    void OnCollisionEnter(Collision collision)
    {
        if (this.tag == "Fruit" && collision.gameObject.tag == "Animal")
        {
            ren = GetComponent<Renderer>();
            ren.material.SetColor("_Color", Color.green);
            score.isAnimal = true;
            score.time = timer.GetElapsedSeconds();
            this.tag = "Animal";
            collision.gameObject.GetComponent<PlayerScore>().takedowns++;
        } 
    }
}
