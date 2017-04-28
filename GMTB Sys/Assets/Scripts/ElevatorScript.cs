using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float speed = 2.3f;
    public Vector3 TargetFloor;

    // Use this for initialization
    void Start()
    {
        // Link rb2d to the Elevator's physical component
        rb2d = GetComponent<Rigidbody2D>();
        // Set starting position
        TargetFloor = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Only run if the TargetFloor is different to where the Elevator currently is
        if (transform.position != TargetFloor)
        {
            // Move to the target floor over time at the specified speed
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, TargetFloor, step);
        }       
    }

    public void MoveTo(float floor)
    {
        // Elevator Button calls this method, sending the destiation floor via the Parameter
        TargetFloor.y = floor;
    }
}
