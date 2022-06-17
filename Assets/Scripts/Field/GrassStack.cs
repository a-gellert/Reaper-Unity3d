using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassStack : MonoBehaviour
{
    private Rigidbody _rb;
    private Collider _coll;
    private Transform SoilParent;
    public bool IsInBackpack { get; private set; }
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _coll = GetComponent<BoxCollider>();
        SoilParent = transform.parent;
    }

    public void InBackpack(Transform transform, float x, float y)
    {
        IsInBackpack = true;
        _rb.isKinematic = true;
        _coll.enabled = false;
        this.transform.SetParent(transform);
        this.transform.localPosition = new Vector3(x, y, 0);
        this.transform.localRotation = new Quaternion(0, 0, 0, 0);
    }
    public void InAmbar(Vector3 target)
    {
        this.transform.SetParent(null);
        _coll.enabled = true;
        _coll.isTrigger = true;
        transform.position = Vector3.Lerp(transform.position, target, 5f * Time.deltaTime);

    }
    public void Init()
    {
        IsInBackpack = false;
        _coll.isTrigger = false;
        _rb.isKinematic = false;
        this.transform.SetParent(SoilParent);
        this.transform.localPosition = new Vector3(0, 0, 0);
        this.transform.localRotation = new Quaternion(0, 0, 0, 0);
        this.gameObject.SetActive(false);
    }


}
