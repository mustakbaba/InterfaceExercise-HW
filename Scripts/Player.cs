using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public Rigidbody Rigidbody { get { return (_rigidbody == null) ? _rigidbody = GetComponent<Rigidbody>() : _rigidbody; } }
    public GameObject panel;

    public float MoveSpeed = 0, sensitivity = 10f;
    public static IInteractable interactableObject;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(interactableObject);
            //EventManager.OnCloser.Invoke();
            if (interactableObject != null)
            {
                interactableObject.Interact();
                interactableObject = null;
                panel.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Rigidbody.velocity = movement * MoveSpeed * Time.fixedDeltaTime;

        


    }

    private void OnTriggerEnter(Collider other)
    {
        
        interactableObject = other.gameObject.GetComponent<IInteractable>();
        panel.SetActive(true);
        EventManager.OnInteractReady.Invoke(interactableObject);
        
        Debug.Log("Enabled interact with: " + interactableObject);

    }

    private void OnTriggerExit(Collider other)
    {
        interactableObject = null;
        panel.SetActive(false);

        Debug.Log("Disabled interact with: " + interactableObject);
    }

}
