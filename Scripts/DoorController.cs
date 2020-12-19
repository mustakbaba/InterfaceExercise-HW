using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour, IUsable
{
    private bool isDoorOpen = false;
    private Animator anim;
    public Animator Anim { get { return (anim == null) ? anim = GetComponent<Animator>() : anim; } }

    public void Take()
    {
        if (!isDoorOpen)
        {
            Anim.SetTrigger("DoorOpenTrigger");
            isDoorOpen = true;
            Debug.Log("You opened the door");
        }

    }
    public void Spend()
    {
        
        Debug.Log("You closed the door");
        Anim.SetTrigger("DoorCloseTrigger");
        isDoorOpen = false;
        
    }

    
}
