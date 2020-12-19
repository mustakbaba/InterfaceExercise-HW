using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apple : MonoBehaviour, IInteractable
{
    private Text _text;
    public Text ShowText { get { return _text == null ? _text = FindObjectOfType<Text>() : _text; } }
    
    public void Interact()
    {
        FindObjectOfType<Player>().playerHealth += 2;
        Debug.Log("You ate an apple. Player Health: " + FindObjectOfType<Player>().playerHealth.ToString());
    }

    public void UpdateUI()
    {
        ShowText.text = "Eat";
    }
}
