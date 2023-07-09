using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatFingerTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("hand-f"))
        {
            Debug.Log(gameObject + " ran in to " + other.name + "! No points.");
        }
    }
}
