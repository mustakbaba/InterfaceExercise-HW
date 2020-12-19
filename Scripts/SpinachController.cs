using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinachController : MonoBehaviour, IUsable
{
    public GameObject charachter;
   
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ninja")
        {
            col.gameObject.transform.localScale += new Vector3(1, 0, 1);
        }
    }

    public void Take()
    {
        BuffText.Instance.starAmount += 1;
        Debug.Log("1 Spinach added to your inventory");
        AddInventory();

    }
    public void Spend()
    {
        if(BuffText.Instance.starAmount == 0)
        {
            return;
        }
        BuffText.Instance.starAmount -= 1;
        charachter.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
        Debug.Log("You are buffed. (1 star decreased from your inventory)");
        RemoveInventory();
    }

    private void AddInventory()
    {
        StarText.Instance.StarTextUI.text = "Buffs: " + StarText.Instance.starAmount;
    }
    private void RemoveInventory()
    {
        StarText.Instance.StarTextUI.text = "Buffs: " + StarText.Instance.starAmount;
    }

}
