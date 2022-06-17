using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToWallet(Vector3 target)
    {
        transform.position = Vector3.Lerp(transform.position, target, 5f * Time.deltaTime);
    }
}
