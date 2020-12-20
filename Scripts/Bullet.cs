using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour,IUsable
{
    
    public void Use()
    {
        Debug.Log("collected bullets");
    }
    public string UiText()
    {
        return "press e for collect ammo";
    }

}
