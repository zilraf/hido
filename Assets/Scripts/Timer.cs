﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int timeLeft = 90;
    public Text countdownText;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("" + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Time's Up!";
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
