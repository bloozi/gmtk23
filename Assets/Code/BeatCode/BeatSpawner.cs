using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSpawner : MonoBehaviour
{
    [SerializeField] GameObject yBeat;
    [SerializeField] GameObject rBeat;
    [SerializeField] GameObject gBeat;
    [SerializeField] GameObject bBeat;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            SpawnBeat(yBeat);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            SpawnBeat(rBeat);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            SpawnBeat(gBeat);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            SpawnBeat(bBeat);
        }
    }

    void SpawnBeat(GameObject objToSpawn)
    {
        Instantiate(objToSpawn, objToSpawn.GetComponent<BeatPath>().Points[0].transform.position, Quaternion.identity);
    }
}
