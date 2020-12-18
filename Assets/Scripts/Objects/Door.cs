using UnityEngine;

public class Door : CollectableBase
{
    public Door()
    {
        action = "Kapıyı Aç";
    }

    public override void Use()
    {
        Debug.Log("Kapı Açıldı !");
        Dispose();
    }
}
