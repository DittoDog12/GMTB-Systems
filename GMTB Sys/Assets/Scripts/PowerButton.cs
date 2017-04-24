using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public float PowertoAdd;
    private bool Active;

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
        if (Active == false)
        {
            Console.AddPower(PowertoAdd);
            Active = true;
            Debug.Log(Active);
        }
           
        else if (Active == true)
        {
            Console.RemovePower(PowertoAdd);
            Active = false;
            Debug.Log(Active);
        }
            
    }
}
