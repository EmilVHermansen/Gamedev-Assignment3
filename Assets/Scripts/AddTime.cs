using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTime : MonoBehaviour
{
    [SerializeField] CountdownScript countdownScript;
    [SerializeField] AudioSource yeet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            yeet.Play();
            print("hej er du der");
            countdownScript.IncrementTime();
        }

    }
}
