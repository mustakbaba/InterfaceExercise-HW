using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : UsableBase
{
    public Apple()
    {
        message = "Ye";
    }
    public override void Use()
    {
        Debug.Log("Can arttı");
    }

}
