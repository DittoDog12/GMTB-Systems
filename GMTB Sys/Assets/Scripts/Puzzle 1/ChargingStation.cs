using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Puzzle_1
{
    public class ChargingStation : MonoBehaviour
    {
        public GameObject Player;
        public Battery battery;
        public Puzzle1Controller puzzleController;

        public bool chargingBattery = false;
        public bool inProximity = false;

        void Start()
        {
        }

        public void input()
        {
            if (Input.GetKeyDown(KeyCode.E) && inProximity == true)// && puzzleController.isHoldingBattery() == true)
            {
                Debug.Log("charging");
                battery.isCharging = true;
                puzzleController.setBattery(false);
                chargingBattery = true;
            }
            if (Input.GetKeyDown(KeyCode.E) && inProximity)// == true && chargingBattery)
            {
                Debug.Log("battery removed");
                battery.isCharging = false;
                //holdingBattery = false;
                //puzzleController.setBattery(true);
                //battery.setPickedUp(true);
            }

        }
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                inProximity = true;
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            if(collision.tag == "Player")
            {
                inProximity = false;
            }
        }
        void update()
        {
            input();

        }
    }
}
