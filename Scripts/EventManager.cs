using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    //public static UnityEvent OnEat = new UnityEvent();
    //public static UnityEvent OnCollect = new UnityEvent();
    //public static UnityEvent OnToggle = new UnityEvent();
    public static InteractEvent OnInteractReady = new InteractEvent();
}

public class InteractEvent : UnityEvent<IInteractable> { };
