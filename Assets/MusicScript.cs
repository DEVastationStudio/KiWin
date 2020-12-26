using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicScript : MonoBehaviour
{
    [SerializeField] private Sprite musicOnImg;
    [SerializeField] private Sprite musicOffImg;
    [SerializeField] private Image btnImg;

    private bool isMusicOn = true;

    public void MusicButton() 
    {
        isMusicOn = !isMusicOn;
        if (isMusicOn)
            btnImg.sprite = musicOnImg;
        else
            btnImg.sprite = musicOffImg;



    }
}
