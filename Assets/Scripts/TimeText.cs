using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour, IUiText
{
    [SerializeField] private Text timeText;

    private string currentTime;
    private bool firstInitialized;

    private void Awake()
    {
        timeText = this.GetComponent<Text>();
    }

    private void Start()
    {
        firstInitialized = true;
        StartCoroutine(updateTimeText());
    }
    private IEnumerator updateTimeText()
    {
        // yeild return new WaitForSeconds()의 경우
        // 매번 새로운 waitforseconds 인스턴스를 만들기 때문에
        // new를 한번만 할 수 있도록 만들었다.
        WaitForSeconds delay1min = new WaitForSeconds(60f);
        
        while (true)
        {
            currentTime = DateTime.Now.ToString("hh:mm");
            SetText(currentTime);
            
            //첫 실행때는 초를 계산하여 다음 시계의 업데이트 시간을 결정한다.
            if (firstInitialized)
                yield return new WaitForSeconds(60 - DateTime.Now.Second);
            else
                yield return delay1min;
        }
    }

    public void SetText(string _time)
    {
        timeText.text = _time;
    }
}
