using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : InteractableBase
{
    public Bullet()
    {        
        mouseOverText = "Mermiyi toplamak için ";
    }
    public override void MouseOver()
    {
        base.MouseOver();
    }

    public override void Interact()
    {
        GameManager.Instance.ammoCount += 1;
        Debug.Log("Ammo: " + GameManager.Instance.ammoCount);
        Dispose();
    }

    public override void Dispose()
    {
        base.Dispose();
    }
}
