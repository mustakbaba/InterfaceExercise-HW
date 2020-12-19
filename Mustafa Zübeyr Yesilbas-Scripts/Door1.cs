using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door1 : MonoBehaviour,IDetectable
{
     public Text My_Text;
    public void ShowButton()
    {
         
        My_Text.text="Kapıyı Açmak İçin E tuşuna Basın";
        Debug.Log("Kapıyı Açmak İçin E tuşuna basın");
    }
    
    
    public void Action()
    {
        
        if(Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Kapı Açıldı");
            Debug.Log("Yeni Bölüm Yükleniyor");
        }
    }

    public void CloseButton()
    {
        Debug.Log("Text kaptıldı") ;  

    }
    
}
