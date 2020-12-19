using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bullet1 : MonoBehaviour,IDetectable
{
      public Text My_Text;  
        public void Action()
    {
       
        if(Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Mermi ALındı");
            Debug.Log("Silah Dolu");
            Destroy(gameObject);
        }
    }
    
    
    public void ShowButton()
    {
         
       
        My_Text.text="Mermiyi Almak İçin E ye basın";
        Debug.Log("Mermiyi Almak İçin E ye basın");
    }

    public void CloseButton()
    {
         Debug.Log("Default State");
          
    }
}
