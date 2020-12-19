using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetecter1: MonoBehaviour
{
   
  
  private void OnTriggerEnter(Collider other) 
  {
       
       IDetectable Detectable =other.gameObject.GetComponent<IDetectable>();
      
      if(Detectable!=null)
      {
        Detectable.ShowButton();

      }
   
  } 
    private void OnTriggerStay(Collider other) 
   {
     
      IDetectable Detectable =other.gameObject.GetComponent<IDetectable>();
      
      
      if(Detectable!=null)
        {
          Detectable.Action();
        }
    
    }

    private void OnTriggerExit(Collider other) 
    {
      
      IDetectable Detectable =other.gameObject.GetComponent<IDetectable>();
     
      
      if(Detectable!=null)
      {
         Detectable.CloseButton();
      }
    }
         
}

