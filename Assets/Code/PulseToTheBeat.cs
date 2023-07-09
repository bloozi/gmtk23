using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseToTheBeat : MonoBehaviour
{
    [SerializeField] public bool _useTestBeat;
    [SerializeField] public float _pulseSize = 1.15f;
    [SerializeField] public float _returnSpeed = 5f;
    public Vector3 _startSize;

    private void Start() 
    {
        _startSize = transform.localScale;
        if (_useTestBeat)
        { 
            StartCoroutine(TestBeat());
        
        }
    }

    
    public virtual void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, _startSize, Time.deltaTime * _returnSpeed);
    }
    
    public virtual void Pulse() 
    {
        transform.localScale = _startSize * _pulseSize;
        // here, spawn collider at the start positions. those colliders will be triggers... if puck in collider then max points?
    }

    IEnumerator TestBeat()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Pulse();

        }


    }
}
