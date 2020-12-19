using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractiveText : Singleton<InteractiveText>
{
    Text text;
    Text Text { get { return (text == null) ? text = GetComponent<Text>() : text; } }

    public bool intHappened;


    public void IsActive (bool isActive)
    {
        gameObject.SetActive(isActive);
    }
    public void PopUp(string gameObj)
    {
        Text.text = "Press E to interact with " + gameObj;
        intHappened = true;

    }

}
