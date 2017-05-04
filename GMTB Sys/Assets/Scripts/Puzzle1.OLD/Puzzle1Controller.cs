using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Controller : MonoBehaviour
{
    public float Target;
    public float DrainPerAttempt;
    private float Power;

    public Battery _Battery;

    public PowerController PwrCtrl;
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
        if (Power == Target)
            PwrCtrl.PowerOn();

        if (Power > Target)
            _Battery.Charge -= DrainPerAttempt;
        
    }

    public void AddPower(float incomingPower)
    {
        Power += incomingPower;
    }

    public void RemovePower(float incomingPower)
    {
        Power -= incomingPower;
    }

    public void ConnectBattery(Battery batt)
    {
        _Battery = batt;
    }
}
