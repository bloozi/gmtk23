using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public GameObject obj;
    public GameObject[] pathPoints;
    public int numberofPoints;
    public float speed;

    public Vector3 actualPosition;
    public int x;
    

    // Start is called before the first frame update
    void Start()
    {
        x = 1;
        
    }

    // Update is called once per frame
    public virtual void Update()
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
