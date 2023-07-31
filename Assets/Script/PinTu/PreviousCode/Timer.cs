using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    bool isStop = false;
    public Text SuccessTime;
    public Text AlmostSucessTime;
    public Text FailTime;
    public GameObject SuccessPanel;
    public GameObject AlmostSuccessPanel;
    public GameObject FailPanel;

    float timer_f = 0f;
    int timer_i = 0;

    void Update()
    {
        if (SuccessPanel.activeSelf)
        {
            isStop = true;
            SuccessTime.text = "總共花費:" + timer_i + "秒";
        }

        if (AlmostSuccessPanel.activeSelf)
        {
            isStop = true;
            AlmostSucessTime.text = "總共花費:" + timer_i + "秒";
        }

        if (FailPanel.activeSelf)
        {
            isStop = true;
            FailTime.text = "總共花費:" + timer_i + "秒";
        }

        if (!isStop)
        {
            timer_f += Time.deltaTime;
            timer_i = (int)timer_f;

            //Debug.Log(timer_i);
        }
    }

    public void UpdateIsStopState(){
        isStop = false;
    }
}