using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private Score scoreSystem;
    private TimingText timingTextSystem;

    // ref score script
    // beatcollider call add score script here

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        scoreSystem = GameObject.Find("ScoreText").GetComponent<Score>();
        timingTextSystem = GameObject.Find("TimingRep").GetComponent<TimingText>();
    }

    public void AddScore(int add)
    {
        scoreSystem.AddScore(add);
    }

    public void FlashPerfect()
    {
        timingTextSystem.SendTimingStr();
    }
}
