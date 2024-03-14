using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TImerTest : MonoBehaviour
{

    public Timer timer; // Reference to the Timer class
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        // Create a timer with an interval of 2 seconds
        timer = gameObject.AddComponent<Timer>();
        timer.Interval = 2; // Set the interval (in seconds)

        // Record the start time
        startTime = Time.time;

        // Start the timer
        timer.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the timer has finished
        if (timer.IsFinished())
        {
            // Perform any actions you want when the timer finishes
            Debug.Log("Timer finished!");
            Debug.Log(timer.ElapsedTime);
        }
    }
}
