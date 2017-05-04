using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.scripts
{

    public class PowerController : MonoBehaviour
    {
        //public GameObject ElevatorDeck1;
        //public GameObject ElevatorDeck2;
        //public GameObject ElevatorDeck3R;
        //public GameObject ElevatorDeck3L;
        //public GameObject ElevatorDeck4L;
        //public GameObject ElevatorDeck4R;
        //public GameObject ElevatorDeck5L;
        //public GameObject ElevatorDeck5R;
        //public GameObject ElevatorDeck6;
        public ElevatorController elevators;

        public GameObject RedLight1;
        public GameObject RedLight2;
        public GameObject RedLight3;
        public GameObject RedLight4;
        public GameObject RedLight5;
        public GameObject RedLight6;
        public GameObject RedLight7;
        public GameObject RedLight8;
        public GameObject RedLight9;
        public GameObject RedLight10;
        public GameObject RedLight11;
        public GameObject RedLight12;
        public GameObject RedLight13;

        public GameObject WhiteLight1;
        public GameObject WhiteLight2;
        public GameObject WhiteLight3;
        public GameObject WhiteLight4;
        public GameObject WhiteLight5;
        public GameObject WhiteLight6;
        public GameObject WhiteLight7;
        public GameObject WhiteLight8;
        public GameObject WhiteLight9;
        public GameObject WhiteLight10;
        public GameObject WhiteLight11;
        public GameObject WhiteLight12;
        public GameObject WhiteLight13;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void PowerOn()
        {
            #region Elevators
            //ElevatorDeck1.GetComponent<Collider2D>().enabled = true;
            //ElevatorDeck2.GetComponent<Collider2D>().enabled = true;
            //ElevatorDeck3R.GetComponent<Collider2D>().enabled = true;
            //ElevatorDeck3L.GetComponent<Collider2D>().enabled = true;
            //ElevatorDeck4L.GetComponent<Collider2D>().enabled = true;
            //ElevatorDeck4R.GetComponent<Collider2D>().enabled = true;
            //ElevatorDeck5L.GetComponent<Collider2D>().enabled = true;
            //ElevatorDeck5R.GetComponent<Collider2D>().enabled = true;
            //ElevatorDeck6.GetComponent<Collider2D>().enabled = true;

            elevators.active = true;
            #endregion

            #region RedLights
            RedLight1.SetActive(false);
            RedLight2.SetActive(false);
            RedLight3.SetActive(false);
            RedLight4.SetActive(false);
            RedLight5.SetActive(false);
            RedLight6.SetActive(false);
            RedLight7.SetActive(false);
            RedLight8.SetActive(false);
            RedLight9.SetActive(false);
            RedLight10.SetActive(false);
            RedLight11.SetActive(false);
            RedLight12.SetActive(false);
            RedLight13.SetActive(false);
            #endregion

            #region WhiteLights
            WhiteLight1.SetActive(true);
            WhiteLight2.SetActive(true);
            WhiteLight3.SetActive(true);
            WhiteLight4.SetActive(true);
            WhiteLight5.SetActive(true);
            WhiteLight6.SetActive(true);
            WhiteLight7.SetActive(true);
            WhiteLight8.SetActive(true);
            WhiteLight9.SetActive(true);
            WhiteLight10.SetActive(true);
            WhiteLight11.SetActive(true);
            WhiteLight12.SetActive(true);
            WhiteLight13.SetActive(true);
            #endregion

        }

    }
}