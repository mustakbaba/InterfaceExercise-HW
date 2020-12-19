using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IUsable
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
			Debug.Log("Kapı Açıldı !");
			UIText.SetActive(false);
		}
	}
	public void Exit()
	{
		UIText.SetActive(false);
	}
}