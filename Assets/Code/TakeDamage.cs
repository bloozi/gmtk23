using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public GameObject board;
    [SerializeField] private int damageAmount;


    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Beat"))
        {
            Debug.Log(other.name);
            other.GetComponent<BoardHealth>().TakeDamage(damageAmount);
        }
        else if (other.name=="board")
        {
            Debug.Log(other.name);
            other.GetComponent<BoardHealth>().TakeDamage(damageAmount);
        }
        
    }

   
}
