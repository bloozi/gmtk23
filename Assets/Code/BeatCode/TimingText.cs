using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimingText : MonoBehaviour
{
    public Text timingText;
    public string timingStr;
    
    void Start()
    {
        timingStr = "";
    }


    void Update()
    {
        timingText.text = timingStr;
    }

    public void SendTimingStr()
    {
        FlashPerfect();
    }

    public void FlashPerfect()
    {
        timingStr = "PERFECT!";
        Invoke("resetStr", 0.3f);
    }

    public void resetStr()
    {
        timingStr = "";
    }
}
