using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour,IUsable
{
   
    public void Use()
    {
        Debug.Log("door opened");
    }
    public string UiText()
    {
        return "press e for open the door";
    }
}
