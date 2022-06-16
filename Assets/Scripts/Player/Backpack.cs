using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    private List<GrassStack> _grassStacks;
    void Start()
    {
        _grassStacks = new List<GrassStack>();
    }

    public void AddGrassStack(GrassStack grassStack)

    {
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
    }
    public void ReleaseBackpack(Transform target)
    {
        _grassStacks.ForEach(x => x.InAmbar(target));
    }
}
