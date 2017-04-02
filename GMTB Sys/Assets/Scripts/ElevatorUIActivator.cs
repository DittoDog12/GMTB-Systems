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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ElevatorUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ElevatorUI.SetActive(false);
        }
    }
}
