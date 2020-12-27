using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>Class that manages the match's scores.</summary>
public class ScoreHandler : MonoBehaviour
{

    public Text text;
    public static List<PlayerScore> playerList;

    ///<summary>Sorts the list of players and displays it on screen.</summary>
    void Start()
    {
        foreach (PlayerScore p in playerList)
        {
            p.score = p.takedowns + (p.time/5);
            if (!p.isAnimal) p.score += playerList.Count;
        }
        playerList.Sort((p1,p2)=>p2.score.CompareTo(p1.score));
        
        text.text = "";
        foreach (PlayerScore p in playerList)
        {
            text.text += p.playerName + " - " + p.score + "(" + p.takedowns + ", " + 
                string.Format("{0:00}", Mathf.Floor(p.time/60)) + ":" + string.Format("{0:00}", Mathf.Floor(p.time%60))
                 + ")\n";
        }
    }

}