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
        string MonthAndDay = DateTime.Now.ToString("MM�� dd��");
        DayText.text = "��¥ : " + MonthAndDay;

        string DayTime = DateTime.Now.ToString("t");
        TimeText.text = "�ð� : " + DayTime;
    }
}
