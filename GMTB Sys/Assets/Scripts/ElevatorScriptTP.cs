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
        // Set the X position to the intended floor
        newPosition.x = floor;
        // Set the Z position to the same, prevents any layering issues
        newPosition.z = player.transform.position.z;
        // Apply the new position to the player
        player.transform.position = newPosition;
    }
    public void setShaft(float shaft)
    {
        // Set the Y position to the current elevator shaft
        newPosition.y = shaft;
    }
}
