using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Puzzle_1
{
    public class PowerButton : MonoBehaviour
    {
        public float powerVal;
        private bool Active = false;

        public Puzzle1Controller Console;
        
        // Use this for initialization
        void Start()
        {
        }
        
        // Update is called once per frame
        void Update()
        {

        }

        private void OnMouseDown()
        {
            // IConsoleCharge charging = gameObject.GetComponent<Puzzle1Controller>();
            if (Console.isHoldingBattery() == true)
            {
                if (Active == false)
                {
                    Console.chargeConsole(powerVal);
                    Active = true;
                    Debug.Log("charging console");
                }

                else if (Active == true)
                {
                    Console.drainConsole(powerVal);
                    Active = false;
                    Debug.Log("Powering down Console");
                }
            }
        }
    }
}