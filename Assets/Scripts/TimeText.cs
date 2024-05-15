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
        // yeild return new WaitForSeconds(1.0f)의 경우
        // 매번 새로운 waitforseconds 인스턴스를 만들기 때문에
        // new를 한번만 할 수 있도록 만들었다.
        WaitForSeconds delay1sec = new WaitForSeconds(1.0f);

        while (true)
        {
            currentTime = DateTime.Now.ToString("hh:mm");
            timeText.text = currentTime;
            yield return delay1sec;
        }
    }
}
