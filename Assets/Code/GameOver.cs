using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    

    private void OnEnable()
    {
        CountdownTimer.OnTimeOut += EnableGameOverScreen;
        

    }

    private void OnDisable()
    {
        CountdownTimer.OnTimeOut -= EnableGameOverScreen;
        
    }

    public void EnableGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }
}
