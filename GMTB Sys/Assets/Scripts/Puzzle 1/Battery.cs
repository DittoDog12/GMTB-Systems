using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Puzzle_1
{
    public class Battery : MonoBehaviour
    {
        public GameObject puzzleController;
        public GameObject player;

        public float storedEnergy = 0;
        public float maxEnergy = 3;
        public bool inConsole = false;
        public bool isCharging = false;
        public bool pickUp = false;
        public bool inProximity = false;

        #region GET/SETS

        public bool getPickedUp()
        {
            return pickUp;
        }
        public void setPickedUp(bool active)
        {
            pickUp = active;
        }

        #endregion

        // Use this for initialization
        void Start()
        {
        }

        #region Power Management

        public void chargeBattery(float powerTransfer)
        {
            storedEnergy = maxEnergy;
            Debug.Log("battery val has changed" + storedEnergy);
        }

        public void drainPower(float transferVal)
        {
            //
            Debug.Log("subtracting power");
            storedEnergy -= transferVal;
        }
        #endregion

        #region Pick Up Battery
        
        public void input()
        {
            if (Input.GetKeyDown(KeyCode.E) && inProximity == true)
            {
                Debug.Log("E Pressed");
                pickUp = true;
                inProximity = false;
                
            }

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player" && pickUp == false)
            {
                inProximity = true;
                // UseButton.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
        #endregion

        // Update is called once per frame
        void Update()
        {
            input();
        }
    }
}