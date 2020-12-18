using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : UsableBase
{
    public Door()
    {
        message = "Aç";
    }
    public override void Use()
    {
        Debug.Log("Kapı açıldı");
    }
}
