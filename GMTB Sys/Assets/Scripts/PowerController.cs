using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerController : MonoBehaviour
{
    public GameObject ElevatorDeck1;
    public GameObject ElevatorDeck2;
    public GameObject ElevatorDeck3R;
    public GameObject ElevatorDeck3L;
    public GameObject ElevatorDeck4L;
    public GameObject ElevatorDeck4R;
    public GameObject ElevatorDeck5L;
    public GameObject ElevatorDeck5R;
    public GameObject ElevatorDeck6;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PowerOn()
    {
        ElevatorDeck1.GetComponent<Collider2D>().enabled = true;
        ElevatorDeck2.GetComponent<Collider2D>().enabled = true;
        ElevatorDeck3R.GetComponent<Collider2D>().enabled = true;
        ElevatorDeck3L.GetComponent<Collider2D>().enabled = true;
        ElevatorDeck4L.GetComponent<Collider2D>().enabled = true;
        ElevatorDeck4R.GetComponent<Collider2D>().enabled = true;
        ElevatorDeck5L.GetComponent<Collider2D>().enabled = true;
        ElevatorDeck5R.GetComponent<Collider2D>().enabled = true;
        ElevatorDeck6.GetComponent<Collider2D>().enabled = true;
    }

}
