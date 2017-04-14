using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScriptTP : MonoBehaviour
{
    public GameObject player;

    private Vector3 newPosition;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveTo(float floor)
    {
        newPosition.y = floor;
        newPosition.z = player.transform.position.z;
        player.transform.position = newPosition;
    }
    public void setShaft(float shaft)
    {
        newPosition.y = shaft;
    }
}
