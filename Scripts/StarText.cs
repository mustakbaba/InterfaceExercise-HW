using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarText : Singleton<StarText>
{
    public int starAmount = 0;
    private Text starTextUI;
    public Text StarTextUI { get { return (starTextUI == null) ? starTextUI = GetComponent<Text>() : starTextUI; } }

    void Start()
    {
        StarTextUI.text = "Star: " + starAmount;
    }
}
