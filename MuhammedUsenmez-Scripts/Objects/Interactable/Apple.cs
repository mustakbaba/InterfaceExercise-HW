using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : InteractableBase
{
    public Apple() 
    {        
        mouseOverText = "Elmayı yemek için ";
    }
    public override void MouseOver()
    {
        base.MouseOver();
    }

    public override void Interact()
    {
        GameManager.Instance.health += 10;
        Debug.Log("Health: " + GameManager.Instance.health);
        Dispose();
    }

    public override void Dispose()
    {
        base.Dispose();
    }
}
