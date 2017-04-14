using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject Player;
    public Vector3 Destination;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Enter");
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E pressed");
            Player.transform.position = Destination;
        }
    }
}
