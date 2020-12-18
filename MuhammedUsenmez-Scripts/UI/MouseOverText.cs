using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MouseOverText : MonoBehaviour
{
    public TextMeshProUGUI mouseOverText;
    private void OnEnable()
    {
        EventManager.OnMouseOver.AddListener(ChangeMouseOverText);
    }

    private void OnDisable()
    {
        EventManager.OnMouseOver.RemoveListener(ChangeMouseOverText);
    }

    private void ChangeMouseOverText(string _text) 
    {
        mouseOverText.text = _text;
    }
}
