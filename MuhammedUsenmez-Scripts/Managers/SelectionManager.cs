using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private GameObject lastSelection;
    private readonly string emptyText = "";
    private void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject obj = hit.collider.gameObject;

            //To avoid multicall same object
            if (lastSelection != obj)
            {
                lastSelection = obj;
                IInteractable interactable = obj.GetComponent<IInteractable>();
                if (interactable != null)
                {
                    interactable.MouseOver();
                }

                else
                {
                    //Reset MouseOver Text
                    EventManager.OnMouseOver.Invoke(emptyText);
                }
            }

        }
        else if(lastSelection!=null)
        {
            lastSelection = null;
            EventManager.OnMouseOver.Invoke(emptyText);
        }
    }

}
