using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IUsable
{

	public GameObject UIText;

	public void Text()
	{
		UIText.SetActive(true);
	}
	public void Action()
	{
		if (Input.GetKey("e"))
		{
			Debug.Log("Mermi Toplandı !");
			Destroy(gameObject);
			UIText.SetActive(false);
		}
	}
	public void Exit()
	{
		UIText.SetActive(false);
	}
}
