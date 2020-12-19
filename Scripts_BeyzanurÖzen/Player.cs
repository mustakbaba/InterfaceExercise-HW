using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	void OnTriggerStay(Collider other)
	{
		var Usable = other.gameObject.GetComponent<IUsable>();
		if (Usable != null)
		{
			Usable.Text();
		}
		Usable.Action();
	}
	void OnTriggerExit(Collider other)
    {
		var Usable = other.gameObject.GetComponent<IUsable>();
		Usable.Exit();
	}

	private Rigidbody rigidbody;
	public Rigidbody Rigidbody
	{
		get
		{
			if (rigidbody == null)
			{
				rigidbody = GetComponent<Rigidbody>();
			}

			return rigidbody;
		}
	}


	public float MoveSpeed;

	public int point = 0;

	private void FixedUpdate()
	{

		Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

		Rigidbody.velocity = input * MoveSpeed * Time.fixedDeltaTime;
	}
}