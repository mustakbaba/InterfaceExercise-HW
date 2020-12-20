using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI useText;
 
    void OnEnable()
    {
        EventManager.textAction += ShowText;
        
    }



    void OnDisable()
    {
        EventManager.textAction -= ShowText;
       
    }

    void ShowText(string a)
    {
        useText.SetText(a+"");
    }
}
