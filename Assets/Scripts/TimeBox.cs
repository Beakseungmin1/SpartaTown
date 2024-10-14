using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class TimeBox : MonoBehaviour
{
    [SerializeField] private Text DayText;
    [SerializeField] private Text TimeText;

    void Update()
    {
        GetCurrentDate();
    }
    public void GetCurrentDate()
    {
        string MonthAndDay = DateTime.Now.ToString("MM월 dd일");
        DayText.text = "날짜 : " + MonthAndDay;

        string DayTime = DateTime.Now.ToString("t");
        TimeText.text = "시간 : " + DayTime;
    }
}
