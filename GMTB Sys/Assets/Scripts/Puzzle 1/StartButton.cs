using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Puzzle_1
{
    public class StartButton : MonoBehaviour
    {
        public Puzzle1Controller Console;

        // Update is called once per frame
        void Update()
        {
        }

        private void OnMouseDown()
        {
            Console.CheckSolution();
            Debug.Log("START BUTTON PRESSED");

        }
    }
}