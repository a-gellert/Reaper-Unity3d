using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trader : MonoBehaviour
{
    [SerializeField] int _exchange = 10;
    [SerializeField] GameObject _coin;
    [SerializeField] Transform target;
    private int _coins = 0;
    private int _stack = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Stack")
        {
            other.gameObject.GetComponent<GrassStack>().Init();
            Trade();
        }
    }

    private void Trade()
    {
        _coins += _exchange;
        UIManager.SetCoins(_coins);
        UIManager.DecrementStack();
        Instantiate(_coin, new Vector3(0, 0, 0), Quaternion.identity);
        StartCoroutine(MoveToTarget(_coin));

    }
    private IEnumerator MoveToTarget(GameObject coin)
    {
        while (true)
        {
            coin.GetComponent<Coin>().ToWallet(target.position);
            yield return null;
        }
    }

}
