using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Door : MonoBehaviour, IInteractable
{
    private bool isOpen = false;
    private Text _text;
    public Text ShowText { get { return _text == null ? _text = FindObjectOfType<Text>() : _text; } }

    public void Interact()
    {
        if (isOpen)
        {
            Debug.Log("You closed the door.");
            GetComponent<Animator>().SetTrigger("Closing");
            isOpen = false;
        }
        else
        {
            Debug.Log("You opened the door.");
            GetComponent<Animator>().SetTrigger("Opening");
            isOpen = true;
        }
        
    }

    public void UpdateUI()
    {
        ShowText.text = "Interact with the door";
    }
}
