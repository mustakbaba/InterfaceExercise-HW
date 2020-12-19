using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("Eat Watermelon!");
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
        if(showGui && Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Nom nom!"); 
            Destroy(gameObject);
        }
    }
}
