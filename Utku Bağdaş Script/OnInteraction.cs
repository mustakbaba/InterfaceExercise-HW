using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnInteraction : MonoBehaviour
{
    public static string text = "";
    public Text text2;
    
    void Update()
    {
        Ray point = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetKeyDown(KeyCode.E))
        {
            

            if (Physics.Raycast(point, out RaycastHit hit)) 
            {
                IEatable eatable = hit.collider.GetComponent<IEatable>();
                if(eatable != null)
                {
                    eatable.Use();
                   
                    
                }
            }
        }

       else if(Physics.Raycast(point, out RaycastHit hit))
        {
            IEatable eatable = hit.collider.GetComponent<IEatable>();

            if(eatable != null)
            {
                eatable.ChangeToMainText();
                text2.text = text;
            }
            else
            {

                text = "";
                text2.text = text;
            }

        }
    }
}
