using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour
{
    public Battery _Battery;

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
        if (_Battery != null)
            Console.ConnectBattery(_Battery);
    }

    public void DisconnectBattery()
    {

    }

}
