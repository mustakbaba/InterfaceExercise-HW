using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IEatable
{
    public void ChangeToMainText()
    {
        OnInteraction.text = "Kapıyı açmak için E'ye basınız.";
    }

    public void Dispose()
    {
        throw new System.NotImplementedException();
    }

    public void Use()
    {
        Debug.Log("Door opened");
    }

}
