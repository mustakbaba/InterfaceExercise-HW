using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rigidbody;
    public int moveSpeed;
    public int healthPoint = 0;
    public GameObject player;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

    }

    
    void Update()
    {
        
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        rigidbody.AddForce(input * moveSpeed);
    }
}
