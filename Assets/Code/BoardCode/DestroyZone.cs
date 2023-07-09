using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Clone"))
        {
            Debug.Log("Destorying object: " + other.name);
            Destroy(other.gameObject);
        }
    }
}
