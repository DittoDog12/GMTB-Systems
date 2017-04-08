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
        rb2d = GetComponent<Rigidbody2D>();
        TargetFloor = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != TargetFloor)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, TargetFloor, step);
        }       
    }

    public void MoveTo(float floor)
    {
        TargetFloor.y = floor;
    }
}
