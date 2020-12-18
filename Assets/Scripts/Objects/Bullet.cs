using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : CollectableBase
{
    public Bullet()
    {
        action = "Ateş Et";
    }

    public override void Use()
    {
        Debug.Log("Ateş Edildi !");
        Dispose();
    }
}
