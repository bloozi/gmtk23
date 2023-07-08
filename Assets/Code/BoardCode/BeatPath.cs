using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatPath : MonoBehaviour
{
    [SerializeField] public Transform[] Points; // the path points

    [SerializeField] private float _moveSpeed;
    private int _pointsIndex;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Points[_pointsIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (_pointsIndex <= Points.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Points[_pointsIndex].transform.position, _moveSpeed * Time.deltaTime);

            if (transform.position == Points[_pointsIndex].transform.position)
            {
                _pointsIndex += 1;
            }
        }
    }
}
