using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody _playerRB;
    public Rigidbody PlayerRB { get { return _playerRB == null ? _playerRB = GetComponent<Rigidbody>() : _playerRB; } }
    [SerializeField] private float _moveSpeed;
    public int playerHealth = 5;
    private GameObject interactableObject;

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Vector3 newMove = input * _moveSpeed * Time.fixedDeltaTime;
        newMove.y = PlayerRB.velocity.y;
        PlayerRB.velocity = newMove;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (interactableObject == null) return;
            if (interactableObject.GetComponent<IInteractable>() == null) return;

            interactableObject.GetComponent<IInteractable>().Interact();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IInteractable>() == null)
            return;

        interactableObject = other.gameObject;
        other.GetComponent<IInteractable>().UpdateUI();
    }
    private void OnTriggerExit(Collider other)
    {
        interactableObject = null;
        FindObjectOfType<Text>().text = "Can't find a close object.";
    }
}
