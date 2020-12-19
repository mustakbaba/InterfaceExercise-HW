using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour, IInteractable
{
    public string InfoMessage()
    {
        return "COLLECT THE AMMEO";
    }

    public void Interact()
    {
        Collect();
    }

    private void Collect()
    {
        Debug.Log("Ammo collected!");
        Destroy(gameObject);
    }
}
