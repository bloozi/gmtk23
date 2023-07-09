using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yFinger : Path
{

    void Start()
    {
        x = 1;

    }

    public float udelay = 8;
    public float timer;
    public float ndelay = 10;

    // Update is called once per frame
    public override void Update()
    {
        actualPosition = obj.transform.position;
        obj.transform.position = Vector3.MoveTowards(actualPosition, pathPoints[x].transform.position, speed * Time.deltaTime);
        timer += Time.deltaTime;
        
        if (timer > udelay && x == 0)
        {
            x++;
        }
        
        else if (actualPosition == pathPoints[x].transform.position && x == 1)
        {

            x++;
        }

        else if (timer > ndelay && x == 2)
        {

            if (x == numberofPoints - 1)
            {
                x = 0;
                timer = 0;
            }

        }
       

    }
}
