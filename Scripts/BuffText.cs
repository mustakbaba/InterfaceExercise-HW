using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuffText : Singleton<StarText>
{
    public int buffAmount = 0;
    private Text buffTextUI;
    public Text BuffTextUI { get { return (buffTextUI == null) ? buffTextUI = GetComponent<Text>() : buffTextUI; } }

    void Start()
    {
        BuffTextUI.text = "Star: " + buffAmount;
    }
}
