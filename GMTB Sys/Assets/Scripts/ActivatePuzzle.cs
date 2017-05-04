using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePuzzle : MonoBehaviour 
{
	public GameObject UseButton;
	public GameObject Player;
	public GameObject Puzzle;

	private bool inProximity;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.E) && inProximity == true) 
		{
			Puzzle.SetActive (true);
			Player.SetActive (false);
			Debug.Log ("PuzzleActivated");
		}

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log ("Enter Trigger");
		if (collision.tag == "Player") 
		{
			Debug.Log ("enter collision");
			inProximity = true;
			UseButton.GetComponent<SpriteRenderer> ().enabled = true;
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
