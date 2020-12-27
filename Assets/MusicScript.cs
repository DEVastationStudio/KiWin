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

    /* This methods controls the music button sprite and changes a boolean depending on the state of the music.
     * This boolean will be used to turn on and off the volume once the sound integration is done
     */
    public void MusicButton() 
    {
        isMusicOn = !isMusicOn;
        if (isMusicOn)
            btnImg.sprite = musicOnImg;
        else
            btnImg.sprite = musicOffImg;



    }
}
