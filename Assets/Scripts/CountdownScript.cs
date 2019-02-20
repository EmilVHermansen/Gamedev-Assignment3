using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft <= 0f)
        {
            timerText.text = "TIME OUT";
        }
        else
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Timer: " + timeLeft.ToString("F2");
        }

    }

    public void IncrementTime()
    {
        timeLeft += 5;
    }

}
