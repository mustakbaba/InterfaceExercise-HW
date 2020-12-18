using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractableBase
{
    public Door()
    {        
        mouseOverText = "Kapıyı açmak için ";
    }
    public override void MouseOver()
    {
        base.MouseOver();
    }

    public override void Interact()
    {
        Debug.Log("Kapı açıldı.");
    }
}
