using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

public static class EventManager
{
    public static MouseOverEvent OnMouseOver = new MouseOverEvent();
}

public class MouseOverEvent : UnityEvent<string> { };
