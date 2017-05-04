using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Puzzle_1
{
    public class Puzzle1Controller : MonoBehaviour
    {
        public float Target = 10;
        public float DrainPerAttempt = 1;
        public float Power = 0;

        public bool holdingBattery;

        public ChargingStation charger;
        public Battery battery;        

        #region GET/SETS

        public bool isHoldingBattery()
        {
            return holdingBattery;
        }
        public void setBattery(bool holding)
        {
            holdingBattery = holding;
        }
        #endregion

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            //CheckSolution();
            if (battery.getPickedUp() == true)
            {
                holdingBattery = true;
            }
        }

        public void CheckSolution()
        {
            if (Power == Target)
            {
                //Puzzle Complete
               Debug.Log("SUCCESS");
            }
            else if (Power != Target)
            {
                Debug.Log("FAIL");
            }

            if (Power > Target)
            {
                battery.drainPower(DrainPerAttempt);
                Power = 0;
            }

        }

        #region CONSOLE POWER MANAGEMENT

        //ADD power to console
        public void chargeConsole(float transfer)
        {
            //INCREASE POWER BASED ON BUTTON VALUE
            Power += transfer;
        }

        //Remove power from console
        public void drainConsole(float incomingPower)
        {
            Power -= incomingPower;
        }

        public void ConnectBattery(Battery batt)
        {
            battery = batt;
        }
        #endregion
    }
}