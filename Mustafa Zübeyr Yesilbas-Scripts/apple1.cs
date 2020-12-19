using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apple1 : MonoBehaviour ,IDetectable
{
     public UnityEngine.UI.Text My_Text;
       public void Action()
    {
       if(Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Elma Yendi Can 10 birim arttı");
            Destroy(gameObject);
        }
    }
   
        
            

       
        public void ShowButton()
    {
        
       
        My_Text.text="Elmayı Yemek için E ye Basın";
        Debug.Log("Elmayı Yemek için E ye Basın");
        
        
    }

    public void CloseButton()
    {
        Debug.Log("Text kapatıldı") ;  
    }
    

    

}

