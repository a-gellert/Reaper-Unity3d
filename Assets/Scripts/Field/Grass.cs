using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    [SerializeField] private Transform _grassGC;
    [SerializeField] private Transform _stackGC;
    void Start()
    {

    }

    public void CutGrass()
    {
        _grassGC.gameObject.SetActive(false);
        _stackGC.gameObject.SetActive(true);
    }
    void Update()
    {

    }
}
