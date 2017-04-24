using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject Player;
    public Vector3 Destination;
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
            Player.transform.position = Destination;
            Debug.Log("E Pressed");
        }
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.tag == "Player") 
		{
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
