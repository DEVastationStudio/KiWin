using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    
    public string playerName;
    public int takedowns;
    public int score;
    public int time;
    public bool isAnimal;

    public void init(string playerName, int takedowns, int time, bool isAnimal)
    {
        this.playerName = playerName;
        this.takedowns = takedowns;
        this.time = time;
        this.isAnimal = isAnimal;
    }
    
}
