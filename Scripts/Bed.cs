using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour, IController
{
    private bool trigger = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Oyuncu Yatti");
            trigger = true;
            
        }
        Touch();
    }
   
    public void Touch()
    {
        if(trigger)
        {
            
            Debug.Log("5 Puan Artti ");
        }

    }
}
