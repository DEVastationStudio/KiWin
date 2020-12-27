using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>Class that manages an in-game timer, and calls an event when the timer ends.</summary>
public class GameTimerController : MonoBehaviour
{
    public delegate void TimerEndDelegate();
    public TimerEndDelegate OnTimerEnd;
    public Text timerText;
    public bool autoStart = false;
    public int initialSeconds = 90;
    private float _timer = 0;
    private int _maxTime;

    ///<summary>When this object is created, the timer will start if <paramref name="autoStart"/> is set to true.</summary>
    void Start()
    {
        OnTimerEnd += StopTimer;
        if (autoStart)
        {
            BeginTimer(initialSeconds);
        }
        else
        {
            FormatTimer();
        }
    }

    ///<summary>If the timer is still running, it will decrease until it finishes. When that happens, <paramref name="OnTimerEnd"/> will be called.</summary>
    void Update()
    {
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;
            FormatTimer();
            if (_timer <= 0)
            {
                OnTimerEnd();
            }
        }
    }

    ///<summary>Initializes the timer. An event will be called in <paramref name="seconds"/> seconds.</summary>
    public void BeginTimer(int seconds)
    {
        _maxTime = seconds;
        _timer = seconds;
        FormatTimer();
    }

    ///<summary>Formats the visual text to show how many minutes and seconds are left on the timer.</summary>
    private void FormatTimer()
    {
        timerText.text = string.Format("{0:00}", Mathf.Floor(_timer/60)) + ":" + string.Format("{0:00}", Mathf.Floor(_timer%60));
    }

    ///<summary>Stops the timer, and changes the visual text to "00:00".</summary>
    private void StopTimer()
    {
        timerText.text = "00:00";
        this.enabled = false;
    }

    ///<summary>Returns the seconds left on the timer, rounded down to the nearest int.</summary>
    public int GetElapsedSeconds()
    {
        return Mathf.FloorToInt(Mathf.Max(0,_maxTime-_timer));
    }

}
