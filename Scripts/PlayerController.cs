using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject nearestGameObject = null;
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody; } }

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), Rigidbody.velocity.y/ 10, Input.GetAxis("Vertical"));
    
    Rigidbody.velocity = input* 500 * Time.fixedDeltaTime;
    }
private void Update()
{
    if (nearestGameObject == null)
    {
        return;
    }
    if (Input.GetKeyDown(KeyCode.E))
    {
        IUsable iusable = nearestGameObject.GetComponentInChildren<IUsable>();
        if (iusable != null)
        {
            iusable.Take();
        }
    }
    if (Input.GetKeyDown(KeyCode.F))
    {
        IUsable iusable = nearestGameObject.GetComponentInChildren<IUsable>();
        if (iusable != null)
        {
            iusable.Spend();
        }
    }
}
private void OnTriggerEnter(Collider other)
{
    nearestGameObject = other.gameObject;
        Debug.Log("You can add the item to your inventory by pressing the E key.");
}

private void OnTriggerExit(Collider other)
{
        nearestGameObject = null;
        Debug.Log("There isn't any item around you");
}
}
  
