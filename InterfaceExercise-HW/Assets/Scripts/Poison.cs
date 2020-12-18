using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : UsableBase
{
    public Poison()
    {
        message = "Ye";
    }
    public override void Use()
    {
        Debug.Log("Can arttı");
    }
}
