using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public string InfoMessage()
    {
        return "OPEN THE DOOR";
    }

    public void Interact()
    {
        Toggle();
    }

    private void Toggle()
    {
        Debug.Log("Door opened!");

    }

    
}
