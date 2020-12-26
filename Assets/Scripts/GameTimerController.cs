using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimerController : MonoBehaviour
{
    public delegate void TimerEndDelegate();
    public TimerEndDelegate OnTimerEnd;
    public Text timerText;
    public bool autoStart = false;
    private float _timer = 0;

    void Start()
    {
        OnTimerEnd += StopTimer;
        if (autoStart)
        {
            BeginTimer(90);
        }
        else
        {
            FormatTimer();
        }
    }

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

    public void BeginTimer(int seconds)
    {
        _timer = seconds;
        FormatTimer();
    }

    private void FormatTimer()
    {
        timerText.text = string.Format("{0:00}", Mathf.Floor(_timer/60)) + ":" + string.Format("{0:00}", Mathf.Floor(_timer%60));
    }

    private void StopTimer()
    {
        timerText.text = "00:00";
        this.enabled = false;
    }

}
