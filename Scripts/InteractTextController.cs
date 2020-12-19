using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractTextController : MonoBehaviour
{
    public Text message;
    

    private void OnEnable()
    {
        EventManager.OnInteractReady.AddListener(CloserMessage);
    }

    private void OnDisable()
    {
        EventManager.OnInteractReady.RemoveListener(CloserMessage);

    }

    private void CloserMessage(IInteractable interactionInfo)
    {
        message.text = interactionInfo.InfoMessage();
    }


    private void Start()
    {
        //message.text = "Get closer to an object!";
    }
}
