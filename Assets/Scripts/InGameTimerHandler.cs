using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>Class that sets the timer's OnTimerEnd method.</summary>
public class InGameTimerHandler : MonoBehaviour
{
    public GameTimerController timerController;
    public FadeController fadeController;
    public int timerTime = 9;

    public List<PlayerScore> players;

    ///<summary>Adds the EndTimer method to the timer's delegate.</summary>
    void Start()
    {
        timerController.BeginTimer(timerTime);
        timerController.OnTimerEnd += EndTimer;
    }

    ///<summary>Calls the BeginFade function.</summary>
    private void EndTimer() {
        foreach (PlayerScore p in players)
        {
            if (!p.isAnimal) p.time = timerController.GetElapsedSeconds();
        }
        ScoreHandler.playerList = players;
        fadeController.BeginFade("GameOverScene");
    }
}
