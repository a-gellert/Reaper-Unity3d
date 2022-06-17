using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static int _coins = 0;
    private static int _currentStack = 0;
    [SerializeField] private static int _maxStack = 40;
    [SerializeField] private TMPro.TMP_Text _coinsText;
    [SerializeField] private TMPro.TMP_Text _stackText;

    public static int GetCoins()
    {
        return _coins;
    }
    public static int GetCurrentStack()
    {
        return _currentStack;
    }
    public static int GetMaxStack()
    {
        return _maxStack;
    }
    public static void SetCoins(int coins)
    {
        if (coins > 0)
        {
            _coins = coins;
        }
    }
    public static void DecrementStack()
    {
        if (_currentStack > 0)
        {
            _currentStack--;
        }
    }
    public static void SetCurrentStack(int currentStack)
    {
        if (currentStack > 0 && currentStack <= _maxStack)
        {
            _currentStack = currentStack;
        }
    }

    private void Update()
    {
        _coinsText.SetText(_coins.ToString());
        _stackText.SetText($"{_currentStack}/{_maxStack}");
    }
}
