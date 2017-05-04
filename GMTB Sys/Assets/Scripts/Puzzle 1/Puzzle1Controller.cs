using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.scripts;
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

        public PowerController PwrCtrl;

        public Text ChargeLevel;
        public Text BatteryLevel;

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
            if (holdingBattery == true)
            {
                // Display the current power level
                ChargeLevel.text = Power + " GeV";
                // Display the current battery level
                BatteryLevel.text = ConvertBattery();
            }
            else
            {
                // Make displays blank
                ChargeLevel.text = " ";
                BatteryLevel.text = " ";
            }
        }

        public void CheckSolution()
        {
            if (Power == Target)
            {
                //Puzzle Complete
               Debug.Log("SUCCESS");
                PwrCtrl.PowerOn();
            }
            else if (Power != Target)
            {
                Debug.Log("FAIL");
            }

            if (Power > Target)
            {
                battery.drainPower(DrainPerAttempt);
                //Power = 0;
            }

        }

        public string ConvertBattery()
        {
            // Convert the battery level to a % string
            string Charge = "";
            // Convert float to int then change the string based on the value 
            switch ((int)battery.storedEnergy)
            {
                case 4:
                    Charge = "100%";
                    break;
                case 3:
                    Charge = "75%";
                    break;
                case 2:
                    Charge = "50%";
                    break;
                case 1:
                    Charge = "25%";
                    break;
                case 0:
                    Charge = "0%";
                    break;
                default:
                    Charge = "0%";
                    break;
            }
            return Charge;
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