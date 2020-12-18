using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ActionText : MonoBehaviour,IChangeText
{

    public void DestroyText()
    {
        GetComponent<Text>().text = " ";
    }

    public void ChangeText(string action)
    {
        GetComponent<Text>().text = action;
    }
    
}
