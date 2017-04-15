using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Controller : MonoBehaviour
{
    public float Target;
    public float DrainPerAttempt;
    private float Power;

    public Battery _Battery;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CheckSolution()
    {
        if (Power == Target) { }
        //Puzzle Complete

        if (Power > Target)
            _Battery.Charge -= DrainPerAttempt;
        
    }

    public void addPower(float incomingPower)
    {
        Power += incomingPower;
    }

    public void removePower(float incomingPower)
    {
        Power -= incomingPower;
    }

    public void ConnectBattery(Battery batt)
    {
        _Battery = batt;
    }
}
