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

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
        if ( other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enter IF");

            ElevatorUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");

        if (other.gameObject.CompareTag("Player"))
        {
            ElevatorUI.SetActive(false);
        }
    }
}
