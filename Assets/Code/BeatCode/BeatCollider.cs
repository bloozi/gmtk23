using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("beatCollider"))
        {
            Debug.Log("Perfect beat: " + other.name + "!");
            GameManager.instance.AddScore(10);
            GameManager.instance.FlashPerfect();
        }
        else if (other.name.Contains("hand-f"))
        {
            Debug.Log(gameObject + " ran in to " + other.name + "! No points.");
        }
    }
}
