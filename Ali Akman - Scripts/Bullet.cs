using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IInteractive
{





    public void Text()
    {
        InteractiveText.Instance.IsActive(true);

        InteractiveText.Instance.PopUp(gameObject.name);

    }




    public void Use()
    {
        Debug.Log(gameObject.name + " was used.");
        Dispose();
    }



    public void Dispose()
    {
        Destroy(this.gameObject);
    }

}
