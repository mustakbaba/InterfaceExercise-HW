using UnityEngine;

public class Apple : CollectableBase
{
    public Apple()
    {
        action = "Ye";
    }

    public override void Use()
    {
        Debug.Log("Can Kazanıldı !");
        Dispose();
    }
}
