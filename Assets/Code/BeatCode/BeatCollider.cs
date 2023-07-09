using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Beat"))
        {
            Debug.Log("Perfect beat: " + other.name + "!");
        }
    }
}
