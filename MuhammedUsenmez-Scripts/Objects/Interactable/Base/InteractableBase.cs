using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableBase : MonoBehaviour, IInteractable
{
    public static KeyCode interactKey = KeyCode.E;
    public string mouseOverText;

    public abstract void Interact();  

    public virtual void MouseOver()
    {
        string text = mouseOverText + interactKey.ToString() + " bas";
        EventManager.OnMouseOver.Invoke(text);
    }

    public virtual void Dispose() 
    {
        Destroy(gameObject);
    }
}
