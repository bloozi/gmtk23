using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatPoints : PulseToTheBeat
{
    private GameObject perfectCollider;
    private GameObject perfColliderYCopy;
    private GameObject perfColliderRCopy;
    private GameObject perfColliderGCopy;
    private GameObject perfColliderBCopy;

    public float colliderTime;

    void Start()
    {
        perfectCollider = GameObject.Find("beatCollider");
        perfectCollider.SetActive(false);
        _startSize = transform.localScale;
    }

    public override void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, _startSize, Time.deltaTime * _returnSpeed);
    }

    public override void Pulse()
    {
        transform.localScale = _startSize * _pulseSize;
        perfColliderYCopy = Instantiate<GameObject>(perfectCollider, GameObject.Find("yStart").transform.position, Quaternion.identity);
        perfColliderRCopy = Instantiate<GameObject>(perfectCollider, GameObject.Find("rStart").transform.position, Quaternion.identity);
        perfColliderGCopy = Instantiate<GameObject>(perfectCollider, GameObject.Find("gStart").transform.position, Quaternion.identity);
        perfColliderBCopy = Instantiate<GameObject>(perfectCollider, GameObject.Find("bStart").transform.position, Quaternion.identity);
        
        perfColliderYCopy.SetActive(true);
        perfColliderRCopy.SetActive(true);
        perfColliderGCopy.SetActive(true);
        perfColliderBCopy.SetActive(true);

        Destroy(perfColliderYCopy, colliderTime);
        Destroy(perfColliderRCopy, colliderTime);
        Destroy(perfColliderGCopy, colliderTime);
        Destroy(perfColliderBCopy, colliderTime);
    }
}
