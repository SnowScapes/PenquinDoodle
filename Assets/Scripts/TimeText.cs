using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    [SerializeField] private Text timeText;

    private string currentTime;

    private void Awake()
    {
        timeText = this.GetComponent<Text>();
    }

    private void Start()
    {
        StartCoroutine(updateTimeText());
    }
    private IEnumerator updateTimeText()
    {
        WaitForSeconds delay1sec = new WaitForSeconds(1.0f);

        while (true)
        {
            currentTime = DateTime.Now.ToString("hh:mm");
            timeText.text = currentTime;
            yield return delay1sec;
        }
    }
}
