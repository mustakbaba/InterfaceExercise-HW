using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Penguin : MonoBehaviour, IInteractable
{
    public void Interact()
    {   
        Debug.Log("Pet Penguin!");
    }
    public void Action()
    {
        Update();

    }
     
    public bool showGui=true; 
    void OnGUI()
    {
        if(showGui)GUI.Box(new Rect(0,0,200,50),"Press E to pet Penguin\n R to eat Watermelon" );
    }
    void Update()
    {
        if(showGui && Input.GetKeyDown(KeyCode.E))
        {
            //GetComponent<Animation>().Play("PenguinJump");
            Debug.Log("Penguin Loves you!"); 
        }

    }
}
