using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class CollectableBase : MonoBehaviour, ICollectable
{
    public string action;
    ActionText actionText;
    public CollectableBase()
    {
        this.action = action;
    }
    public void Collect() 
    {
        Debug.Log(action);
        
    }
    public void Dispose() 
    {
        actionText = FindObjectOfType<ActionText>();
        Destroy(gameObject);
        if (actionText == null) return;
        else actionText.DestroyText();
    }
    public abstract void Use();

   

}
