using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Puzzle_1
{
    public class StartButton : MonoBehaviour
    {
        public bool activate = false;
        public Puzzle1Controller Console;

      public void canActivate( bool _activate)
        {
            activate = _activate;
        }

        // Update is called once per frame
        void Update()
        {
            Console.CheckSolution();
            if (activate == true)
            {
               // Debug.Log("success");
                //Animate
            }
        }

        private void OnMouseDown()
        {
            

            if( activate == true)
            {
                Debug.Log("success");                //Run System
                activate = false;

            }

        }
    }
}