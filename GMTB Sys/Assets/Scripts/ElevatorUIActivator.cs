using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.scripts
{

    public class ElevatorUIActivator : MonoBehaviour
    {
        public GameObject ElevatorUI;
        public ElevatorController controller;

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
                if (controller.active == true)
                    ElevatorUI.SetActive(true);
            }
        }

        void OnTriggerExit2D(Collider2D other)
        {
            // Triggers when something leaves the Collider
            if (other.tag == "Player")
            {
                // If the other object is the player, display the ElevatorUI
                if (controller.active == true)
                    ElevatorUI.SetActive(false);
            }
        }
    }
}