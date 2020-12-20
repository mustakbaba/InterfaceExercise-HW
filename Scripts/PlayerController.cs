using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody _rigidbody;
    public Rigidbody Rigidbody
    {
        get
        {
            return (_rigidbody == null) ? _rigidbody = GetComponent<Rigidbody>() : _rigidbody;
        }
    }


    float moveSpeed = 450;



    private void Update()
    {

    }



    void FixedUpdate()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Rigidbody.velocity = movement * moveSpeed * Time.fixedDeltaTime;




    }
    private void OnTriggerEnter(Collider other)
    {
        IUsable obje = other.GetComponent<IUsable>();
        if (obje != null)
        {

            EventManager.textAction.Invoke(obje.UiText());
        }
    }

    private void OnTriggerStay(Collider other)
    {

        IUsable obje = other.GetComponent<IUsable>();
        if (obje != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                obje.Use();
            }


        }
    }


}