using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractive
{




    public void Text()
    {
        InteractiveText.Instance.IsActive(true);

        InteractiveText.Instance.PopUp(gameObject.name);

    }




    public void Use()
    {
        Debug.Log(gameObject.name + " was opened.");
        Dispose();
    }
    
    
    
    public void Dispose()
    {
           Destroy(this.gameObject);
    }

}
