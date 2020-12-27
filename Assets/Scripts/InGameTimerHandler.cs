using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Class that sets the timer's OnTimerEnd method.</summary>
public class InGameTimerHandler : MonoBehaviour
{
    public GameTimerController timerController;
    public FadeController fadeController;

    ///<summary>Adds the EndTimer method to the timer's delegate.</summary>
    void Start()
    {
        timerController.OnTimerEnd += EndTimer;
    }

    ///<summary>Calls the BeginFade function.</summary>
    private void EndTimer() {
        fadeController.BeginFade("GameOverScene");
    }
}
