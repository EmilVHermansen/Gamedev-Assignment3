using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GlobalBananaCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counterText;
    private int counter;
    

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increment()
    {
        print("increment");
        counter++;
        updateCounter();

    }

    private void updateCounter()
    {
        print("updateCounter");
        counterText.text = "Bananas: " + counter.ToString();
    }
}
