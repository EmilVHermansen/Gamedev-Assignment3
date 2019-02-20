using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using DG.Tweening;

public class GlobalBananaCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counterText;
    private int counter;
    private Vector3 startScale;

    // Start is called before the first frame update
    void Start()
    {
        startScale = counterText.transform.localScale;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increment()
    {
        counter++;
        updateCounter();
    }

    private void updateCounter()
    {
        counterText.transform.DOScale(new Vector3(4,4,4), 0.5f);
        counterText.text = "Bananas: " + counter.ToString();
        counterText.transform.DOScale(new Vector3(1,1,1), 1.5f);
    }
}
