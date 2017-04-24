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
        //Debug.Log("Trigger Enter");
        if (other.tag == "Player")
        {
            //Debug.Log("Enter IF");

            ElevatorUI.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log("Trigger Exit");

        if (other.tag == "Player")
        {
            ElevatorUI.SetActive(false);
        }
    }
}
