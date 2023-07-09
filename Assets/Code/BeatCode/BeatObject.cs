using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatObject : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private string color;


    public void BeatObjectInit(int bSpeed, string bColor)
    {
        speed = bSpeed;
        color = bColor;
    }

    public float GetSpeed()
    {
        return speed;
    }
}
