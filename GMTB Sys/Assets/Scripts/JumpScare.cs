using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject HidingBG;
    public GameObject JumpBG;
    public GameObject Trigger;
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
        if (collision.tag == "Player")
        {
            HidingBG.SetActive(false);
            JumpBG.SetActive(true);
            DestroyObject(HidingBG);
            DestroyObject(Trigger);
            Destroy(this);
        }
            
    }
}

