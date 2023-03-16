using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeedrunTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float time = 0f;
    public bool timerRunning = false;

    void Start()
    {

    }

    void Update()
    {
        if (timerRunning)
        {
            time += Time.deltaTime;
            // Set timer text to time in fromat "00:00:00" (hours, minutes, seconds)
            timerText.text = time.ToString("00:00:00");
        }
    }
}
