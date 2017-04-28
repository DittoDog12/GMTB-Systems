using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPuzzle : MonoBehaviour
{
    public GameObject Player;
    public GameObject Puzzle;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click()
    {
        Puzzle.SetActive(false);
        Player.SetActive(true);
    }
}
