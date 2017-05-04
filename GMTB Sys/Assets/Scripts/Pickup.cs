using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery_physical : MonoBehaviour
{
	public Battery batt;
	public GameObject UseButton;

	private bool inProximity = false;
	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.E) && inProximity == true)
		{
			batt.PickedUp = true;
			batt.GetComponent<SpriteRenderer>().enabled = false;
		}
	}

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player") 
		{
			inProximity = true;
			UseButton.GetComponent<SpriteRenderer>().enabled = true;
		}
			
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag == "Player") 
		{
			inProximity = false;
			UseButton.GetComponent<SpriteRenderer> ().enabled = false;
		}
	}
}
