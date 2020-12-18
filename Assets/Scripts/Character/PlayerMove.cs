using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    CollectableBase obje;
    ActionText actionText;
    // Update is called once per frame
    private void Start()
    {
        speed = 10;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
            transform.Translate(-transform.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            transform.Translate(transform.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-transform.right* speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(transform.right * speed * Time.deltaTime);


        if (obje!=null && Input.GetKey(KeyCode.E))
        {
            obje.Use();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        obje = other.GetComponent<CollectableBase>();
        actionText = FindObjectOfType<ActionText>();
        if (obje != null)
        {
            obje.Collect();
            if (actionText == null) return;
            else actionText.ChangeText(other.GetComponent<CollectableBase>().action);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (actionText == null) return;
        else actionText.DestroyText();
    }
}
