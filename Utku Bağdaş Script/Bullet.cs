using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IEatable
{
    public void ChangeToMainText()
    {
        OnInteraction.text = "Mermi toplamak için E'ye basınız.";
    }

    public void Dispose()
    {
        Destroy(gameObject);
    }

    public void Use()
    {
        Debug.Log("bullet collected");
        GameManager.Instance.bulletcount += 1;
        Debug.Log("Bullet count : " + GameManager.Instance.bulletcount);
        Dispose();
    }
}
