using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassStack : MonoBehaviour
{
    private Rigidbody _rb;
    private Collider _coll;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _coll = GetComponent<BoxCollider>();
    }

    public void InBackpack(Transform transform, float x, float y)
    {

        _rb.isKinematic = true;
        _coll.enabled = false;
        this.transform.SetParent(transform);
        this.transform.localPosition = new Vector3(x, y, 0);
        this.transform.localRotation = new Quaternion(0, 0, 0, 0);
    }
    public void InAmbar(Transform target)
    {

    }
    void Update()
    {

    }
}
