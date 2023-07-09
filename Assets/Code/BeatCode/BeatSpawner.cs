using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSpawner : MonoBehaviour
{
    [SerializeField] GameObject yBeat;
    [SerializeField] GameObject rBeat;
    [SerializeField] GameObject gBeat;
    [SerializeField] GameObject bBeat;

    void Start()
    {
        yBeat.SetActive(false);
        rBeat.SetActive(false);
        gBeat.SetActive(false);
        bBeat.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject newBeat;

        if(Input.GetKeyDown(KeyCode.D))
        {
            newBeat = CreateBeat(yBeat, "yellow");
            SpawnBeat(newBeat);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            newBeat = CreateBeat(rBeat, "red");
            SpawnBeat(newBeat);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            newBeat = CreateBeat(gBeat, "green");
            SpawnBeat(newBeat);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            newBeat = CreateBeat(bBeat, "blue");
            SpawnBeat(newBeat);
        }
    }

    private GameObject CreateBeat(GameObject obj, string color)
    {
        if (obj.GetComponent<BeatObject>() == null)
        {
            obj.AddComponent<BeatObject>().BeatObjectInit(10, color);
        }

        // based off of color, find name
        if(color == "yellow")
        {
            if (obj.GetComponent<BeatPath>() == null)
            {
                obj.AddComponent<BeatPath>().BeatPathInit(GameObject.Find("yStart"), GameObject.Find("yEnd"), obj.GetComponent<BeatObject>().GetSpeed());
            }
            
        }
        else if (color == "red")
        {
            if (obj.GetComponent<BeatPath>() == null)
            {
                obj.AddComponent<BeatPath>().BeatPathInit(GameObject.Find("rStart"), GameObject.Find("rEnd"), obj.GetComponent<BeatObject>().GetSpeed());
            }
        }
        else if (color == "green")
        {
            if (obj.GetComponent<BeatPath>() == null)
            {
                obj.AddComponent<BeatPath>().BeatPathInit(GameObject.Find("gStart"), GameObject.Find("gEnd"), obj.GetComponent<BeatObject>().GetSpeed());
            }
        }
        else if (color == "blue")
        {
            if (obj.GetComponent<BeatPath>() == null)
            {
                obj.AddComponent<BeatPath>().BeatPathInit(GameObject.Find("bStart"), GameObject.Find("bEnd"), obj.GetComponent<BeatObject>().GetSpeed());
            }
        }
        return obj;
    }

    void SpawnBeat(GameObject objToSpawn)
    {
        var copy = Instantiate<GameObject>(objToSpawn, objToSpawn.GetComponent<BeatPath>().Points[0].transform.position, Quaternion.identity);
        copy.SetActive(true);
    }
}
