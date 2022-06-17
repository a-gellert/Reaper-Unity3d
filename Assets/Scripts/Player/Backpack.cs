using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    private List<GrassStack> _grassStacks;
    private List<GrassStack> _grassStacksToAmbar;
    void Start()
    {
        _grassStacks = new List<GrassStack>();
        _grassStacksToAmbar = new List<GrassStack>();
    }

    public void AddGrassStack(GrassStack grassStack)

    {
        if (_grassStacks.Count == UIManager.GetMaxStack())
        {
            return;
        }
        float x, y;
        _grassStacks.Add(grassStack);
        y = ((_grassStacks.Count % 2 == 1) ? _grassStacks.Count - 1 : _grassStacks.Count) * 0.3f;

        if (_grassStacks.Count % 2 == 1)
        {
            x = -0.25f;
        }
        else
        {
            x = 0.25f;
        }

        if (_grassStacks.Count != 1 && _grassStacks.Count % 2 == 0)
        {
            y = (_grassStacks.Count - 1) * 0.15f;
        }
        else
        {

            y = _grassStacks.Count * 0.15f;
        }
        grassStack.InBackpack(transform, x, y);
        UIManager.SetCurrentStack(_grassStacks.Count);
    }
    public void ReleaseBackpack(Vector3 target)
    {
        if (_grassStacks.Count > 0)
        {
            _grassStacksToAmbar.Clear();
            _grassStacksToAmbar.AddRange(_grassStacks);
            _grassStacks.Clear();
            _grassStacksToAmbar.Reverse();
        }
        if (_grassStacksToAmbar.Count > 0)
        {
            StartCoroutine(Pick(target));
        }
    }
    private IEnumerator Pick(Vector3 target)
    {
        while (true)
        {
            foreach (var item in _grassStacksToAmbar)
            {
                StartCoroutine(MoveToTarget(item, target));
                yield return new WaitForSeconds(0.05f);
            }

        }

    }
    private IEnumerator MoveToTarget(GrassStack item, Vector3 target)
    {
        while (item.IsInBackpack)
        {
            item.InAmbar(target);
            yield return null;
        }
    }


}