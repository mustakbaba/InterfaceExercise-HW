using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour,IUsable
{
   public void Use()
    {
        Debug.Log("ate apple");
    }
    public string UiText()
    {
        return "press e for eat apple";
    }
}
