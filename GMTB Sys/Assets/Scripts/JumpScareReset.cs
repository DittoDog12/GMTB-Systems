using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareReset : MonoBehaviour
{
    public GameObject JumpBG;
    public GameObject EmptyBG;
    public GameObject Trigger;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            JumpBG.SetActive(false);
            EmptyBG.SetActive(true);
            DestroyObject(JumpBG);
            DestroyObject(Trigger);
            Destroy(this);

        }
    }
}
