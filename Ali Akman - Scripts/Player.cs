using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    Rigidbody Rigidbody { get { return (rb == null) ? rb = GetComponent<Rigidbody>() : rb; } }

    GameObject intObject;


    float moveSpeed = 500f;

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Rigidbody.velocity = move * moveSpeed * Time.fixedDeltaTime;
    }

    private void Update()
    {


        if (InteractiveText.Instance.intHappened)
        {
            if (Input.GetKey(KeyCode.E))
            {
                intObject.GetComponent<IInteractive>().Use();
                InteractiveText.Instance.IsActive(false);

            }
        }
    }




    public void OnTriggerStay(Collider other)
    {
        IInteractive interactiveObj = other.GetComponent<IInteractive>();
        if (interactiveObj != null)
        {
            intObject = other.gameObject;
            interactiveObj.Text();
        }
    }




    private void OnTriggerExit(Collider other)
    {
        InteractiveText.Instance.IsActive(false);
    }

}
