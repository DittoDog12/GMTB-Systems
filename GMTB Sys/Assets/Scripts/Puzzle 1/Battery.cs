using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Puzzle_1
{
    public class Battery : MonoBehaviour
    {
        public Puzzle1Controller puzzleController;
        public GameObject player;

        public float storedEnergy = 0;
        public float maxEnergy = 4;
        public bool inConsole = false;
        public bool isCharging = false;
        public bool pickUp = false;
        public bool inProximity = false;
        public bool charged = false;

		public GameObject useButton;

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
        { }

        #region Power Management

        public void chargeBattery(float powerTransfer)
        {
            storedEnergy = maxEnergy;
            Debug.Log("battery val has changed" + storedEnergy);
        }

        public void drainPower(float transferVal)
        {
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
                puzzleController.setBattery(true);
                inProximity = false;
				GetComponent<SpriteRenderer> ().enabled = false;
				useButton.GetComponent<SpriteRenderer> ().enabled = false;
            }

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player" && pickUp == false)
            {
                inProximity = true;
				useButton.GetComponent<SpriteRenderer> ().enabled = true;
            }
        }

		private void OnTriggerExit2D(Collider2D collision)
		{
			if (collision.tag == "Player" && pickUp == false) 
			{
				inProximity = false;
				useButton.GetComponent<SpriteRenderer> ().enabled = false;
			}
		}
        #endregion

        // Update is called once per frame
        void Update()
        {
            input();

            if (storedEnergy <= 0)
            {
                charged = false;
            }
            else charged = true;
        }
    }
}