using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] private Transform _traderTransform;
    public Vector3 GetTraderPosition()
    {
        return _traderTransform.position;
    }
    // Update is called once per frame
}
