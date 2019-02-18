using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectBananas : MonoBehaviour
{
    [SerializeField] GameObject aircraft;
    [SerializeField] GlobalBananaCounter globalBananaCounter;
    [SerializeField] AudioSource coinSound;
    private bool haveIncrement = false;
   
    private int counter = 0;

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
        coinSound.Play();

        if (!haveIncrement)
        {
            Destroy(gameObject);
            if (col.gameObject.tag == "Player")
            {
                globalBananaCounter.increment();
            }
            haveIncrement = true;
        }

    }
}
