using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour, IEatable
{
    public void ChangeToMainText()
    {
        OnInteraction.text = "Yemek için E'ye basınız.";
    }

    public void Dispose()
    {
        Destroy(gameObject);
    }

    public void Use()
    {
        Debug.Log("Apple eated");
        GameManager.Instance.health += 10;
        Debug.Log("Health : " + GameManager.Instance.health);
        Dispose();
    }
}
