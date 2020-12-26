using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTest : MonoBehaviour
{
    public GameTimerController timerController;
    public FadeController fadeController;

    public void SetupTimer()
    {
        timerController.OnTimerEnd += EndTimer;
        timerController.BeginTimer(9);
    }

    private void EndTimer() {
        Debug.Log("Scene Restarted");
        fadeController.BeginFade("SampleScene");
    }
}
