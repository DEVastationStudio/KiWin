using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{

    public Text text;
    public static List<PlayerScore> playerList;


    public static void InitPlayerList()
    {
        playerList = new List<PlayerScore>();   
    }
    
    void Start()
    {
        foreach (PlayerScore p in playerList)
        {
            p.score = p.takedowns + (p.time/10);
            if (!p.isAnimal) p.score += playerList.Count;
        }
        playerList.Sort((p1,p2)=>p1.score.CompareTo(p2.score));
        
        text.text = "";
        foreach (PlayerScore p in playerList)
        {
            text.text += p.playerName + ": " + p.score + "\n";
        }
    }

}