using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerForMatch : MonoBehaviour
{
    public Text SuccessTime;

    float timer_f = 0f;
    int timer_i = 0;

    bool isStop = false;

    void Update()
    {
        if (!isStop)
        {
            timer_f += Time.deltaTime;
            timer_i = (int)timer_f;

            SuccessTime.text = "總共花費:" + timer_i + "秒";
        }
    }

    public void StopTimer(){
        isStop = true;
    }
}
