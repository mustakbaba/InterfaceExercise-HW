using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour, IUsable
{
    public void Take()
    {
        StarText.Instance.starAmount += 1;
        Debug.Log("1 Star added to your inventory");
        
        AddInventory();
    }
    public void Spend()
    {
        if (StarText.Instance.starAmount==0)
        { return;
        }
        StarText.Instance.starAmount--;
        Debug.Log("You throw a star. (1 star decreased from your inventory)");

        RemoveInventory();

    }
    private void AddInventory()
    {
        StarText.Instance.StarTextUI.text = "Stars: " + StarText.Instance.starAmount;
    }
    private void RemoveInventory()
    {
        StarText.Instance.StarTextUI.text = "Stars: " + StarText.Instance.starAmount;
    }


}
