using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour
{
    public GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer on = fire.GetComponent<SpriteRenderer>();

        if(Input.GetKey(KeyCode.W))
        {
            on.enabled = true;
        }
        else
        {
            on.enabled = false;
        }
    }
}
