using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UsableBase : MonoBehaviour, IUsable
{
    public string message;

    public virtual void Collect()
    {
        Debug.Log(message);
    }
    public abstract void Use();
}
