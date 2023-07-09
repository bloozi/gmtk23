using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public static event Action OnTimeOut;
    public float currentTime = 0f;
    float startingTime = 105f;
    
    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        print(currentTime);

        if (currentTime <= 0)
        {
            currentTime = 0;
            OnTimeOut?.Invoke();
            Time.timeScale = 0f;
        }
        
        else if (currentTime >= 1)
        {
            Time.timeScale = 1f;
        }
    }
}
