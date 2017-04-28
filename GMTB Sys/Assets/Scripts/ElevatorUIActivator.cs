using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorUIActivator : MonoBehaviour
{
    public GameObject ElevatorUI;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Triggers when something enters the Collider
        if (other.tag == "Player")
        {
            // If the other object is the player, display the ElevatorUI
            ElevatorUI.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Triggers when something leaves the Collider
        if (other.tag == "Player")
        {
            // If the other object is the player, display the ElevatorUI
            ElevatorUI.SetActive(false);
        }
    }
}
