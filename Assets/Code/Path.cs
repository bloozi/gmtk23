using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paths : MonoBehaviour
{
    public GameObject obj;
    public GameObject[] pathPoints;
    public int numberofPoints;
    public float speed;

    private Vector3 actualPosition;
    private int x;
    private bool reverse; //set x to 0

    // Start is called before the first frame update
    void Start()
    {
        x = 1;
        reverse = false;
    }

    // Update is called once per frame
    void Update()
    {
        actualPosition = obj.transform.position;
        obj.transform.position = Vector3.MoveTowards(actualPosition, pathPoints[x].transform.position, speed * Time.deltaTime);

        if (actualPosition == pathPoints[x].transform.position && x != numberofPoints - 1)
        {
           
            x++;
        }
        
        else if (x == numberofPoints - 1)
        {
            x = 0;
        }
        
    }
}
