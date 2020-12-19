using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour, IInteractable
{
    public string InfoMessage()
    {
        return "EAT AN APPLE";
    }

    public void Interact()
    {
        Eat();
    }

    private void Eat()
    {
        Debug.Log("Apple ate!");
        Destroy(gameObject);
    }

    
}
